﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileProgram
{
    class Mobile
    {   
        // Declaring variables
        private String device, accType, number;
        private double balance;

        // Declaring constants
        private const double CALL_COST = 0.245;
        private const double TEXT_COST = 0.078;

        // Constructor method
        public Mobile(string accType, string device, string number)
        {
            this.accType = accType;
            this.device = device;
            this.number = number;
            this.balance = 0.0;
        }

        // Get methods
        public String getAccType()
        {
            return this.accType;
        }

        public string getDevice()
        {
            return this.device;
        }

        public string getNumber()
        {
            return this.number;
        }

        public string getBalance()
        {
            return this.balance.ToString("C");
        }

        // Set methods
        public void setAccType(String accType)
        {
            this.accType = accType;
        }

        public void setDevice(String device)
        {
            this.device = device;
        }
        public void setNumber(String number) 
        { 
            this.number = number;
        }

        public void setBalance(double balance) 
        { 
            this.balance = balance;
        }

        // Methods
        public void addCredit(double amount)
        {
            this.balance += amount;
            Console.WriteLine("Credit added successfully. New balance: " + getBalance());
        }

        public void makeCall(int minutes)
        {
            double cost = minutes * CALL_COST;
            this.balance -= cost;
            Console.WriteLine("Call made. New balance: " + getBalance());
        }

        public void sendText(int numTexts)
        {
            double cost = numTexts * TEXT_COST;
            this.balance -= cost;
            Console.WriteLine("Text sent. New balance: " + getBalance());
        }
    }
}
