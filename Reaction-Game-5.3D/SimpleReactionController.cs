using System;
using System.Timers;

namespace SimpleReactionMachine
{
    public class SimpleReactionController : IController
    {
        private IGui gui;
        private IRandom rng;
        private IState currentState;

        public SimpleReactionController()
        {
            currentState = new WaitForCoinState(this);
        }

        // Define IState class
        private interface IState
        {
            abstract void CoinInserted();
            abstract void GoStopPressed();
            abstract void Tick();
        }

        // Define each state of the machine
        private class WaitForCoinState : IState
        {
            private readonly SimpleReactionController controller;

            public WaitForCoinState(SimpleReactionController controller)
            {
                this.controller = controller;
            }

            public void CoinInserted()
            {
                controller.gui.SetDisplay("Press GO!");
                controller.currentState = new WaitForGoState(controller);
            }

            public void GoStopPressed()
            {
                // No operation needed in this state
            }

            public void Tick()
            {
                // No operation needed in this state
            }
        }

        private class WaitForGoState : IState
        {
            // State where the machine is waiting for the player to press 'Go'
            private readonly SimpleReactionController controller;

            public WaitForGoState(SimpleReactionController controller)
            {
                this.controller = controller;
            }

            public void CoinInserted()
            {
                // No operation needed in this state
            }

            // Handler when 'Go' button is pressed
            public void GoStopPressed()
            {
                controller.gui.SetDisplay("Wait...");
                controller.currentState = new WaitingState(controller);
            }

            public void Tick()
            {
                // No operation needed in this state
            }
        }

        // State where the machine waits for a random time before allowing the player to react
        private class WaitingState : IState
        {
            private int waitTime;
            private double elapsedTime;
            private readonly SimpleReactionController controller;

            public WaitingState(SimpleReactionController controller)
            {
                this.controller = controller;
                waitTime = controller.rng.GetRandom(100, 250); // 1.0 to 2.5 seconds
            }

            public void CoinInserted()
            {
                // No operation needed in this state
            }

            // Called every tick, decreasing the wait time
            public void Tick()
            {
                elapsedTime += 0.01;

                if (elapsedTime >= waitTime * 0.01) // Convert waitTime (1.0 - 2.5 seconds) to ticks
                {
                    controller.gui.SetDisplay("0.00");
                    controller.currentState = new TimingState(controller);
                }
            }

            // If player presses 'Go' too early
            public void GoStopPressed()
            {
                controller.gui.SetDisplay("Insert coin");
                controller.currentState = new WaitForCoinState(controller);
            }
        }

        // State where the machine times how fast the player reacts
        private class TimingState : IState
        {
            private double elapsedTime;
            private readonly SimpleReactionController controller;

            public TimingState(SimpleReactionController controller)
            {
                this.controller = controller;
                elapsedTime = 0;
            }

            public void CoinInserted()
            {
                // No operation needed in this state
            }

            public void Tick()
            {
                elapsedTime += 0.01;

                if (elapsedTime >= 2.0) // 2 seconds max reaction time
                {
                    controller.gui.SetDisplay($"{elapsedTime:F2}"); // Ensure display is formatted correctly
                    controller.currentState = new GameOverState(controller);
                }
                else
                {
                    controller.gui.SetDisplay($"{elapsedTime:F2}");
                }
            }

            public void GoStopPressed()
            {
                controller.gui.SetDisplay($"{elapsedTime:F2}");
                controller.currentState = new GameOverState(controller);
            }
        }

        // State after the player's reaction has been timed
        private class GameOverState : IState
        {
            private double displayTime;
            private readonly SimpleReactionController controller;

            public GameOverState(SimpleReactionController controller)
            {
                this.controller = controller;
                displayTime = 0;
            }

            public void CoinInserted()
            {
                // No operation needed in this state
            }

            public void Tick()
            {
                displayTime += 0.01;

                if (displayTime >= 2.0) // Display the result for 2 seconds
                {
                    controller.gui.SetDisplay("Insert coin");
                    controller.currentState = new WaitForCoinState(controller);
                }
            }

            public void GoStopPressed()
            {
                controller.gui.SetDisplay("Insert coin");
                controller.currentState = new WaitForCoinState(controller);
            }
        }

        // Connect the GUI and random number generator to the controller
        public void Connect(IGui gui, IRandom rng)
        {
            this.gui = gui ?? throw new ArgumentNullException(nameof(gui));
            this.rng = rng ?? throw new ArgumentNullException(nameof(rng));
        }

        // Initialize the game's display
        public void Init()
        {
            gui?.SetDisplay("Insert coin");
            currentState = new WaitForCoinState(this);
        }

        // Handler for when a coin is inserted
        public void CoinInserted()
        {
            currentState?.CoinInserted();
        }

        // Handler for the 'Go' button press
        public void GoStopPressed()
        {
            currentState?.GoStopPressed();
        }

        // Handler for every tick of the game's timer
        public void Tick()
        {
            currentState?.Tick();
        }
    }
}

