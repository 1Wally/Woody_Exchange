
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



string moneyAmount;
string moneyType;
double moneyAmountConverted;
string moneyTypeConverting;
double Conversionnumber;
double result = 0;
double saveResult = 0;
string cont = "yes";
int counter = 0;
double bean = 0;

again:

    Console.WriteLine("Please select your currency type between USD, GBP, CAN, or EUR");

    moneyType = Console.ReadLine();

    Console.WriteLine("Please select your currency type you are converting to between USD, GBP, CAN, or EUR");

    moneyTypeConverting = Console.ReadLine();

    Console.WriteLine("Please type your money amount");

    moneyAmount = Console.ReadLine();
    moneyAmountConverted = double.Parse(moneyAmount);

    do
    {

    if (moneyType == "USD")
    {
        if (moneyTypeConverting == "USD")
        {
            Conversionnumber = 1;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "GBP")
        {
            Conversionnumber = .72523;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "CAN")
        {
            Conversionnumber = 1.25427;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "EUR")
        {
            Conversionnumber = .93572;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        };
    }
    else if (moneyType == "GBP")
    {
        if (moneyTypeConverting == "USD")
        {
            Conversionnumber = 1.37887;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "GBP")
        {
            Conversionnumber = 1;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "CAN")
        {
            Conversionnumber = 1.72947;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "EUR")
        {
            Conversionnumber = 1.15195;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        };
    }
    else if (moneyType == "CAN")
    {
        if (moneyTypeConverting == "USD")
        {
            Conversionnumber = .79728;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "GBP")
        {
            Conversionnumber = .57848;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "CAN")
        {
            Conversionnumber = 1;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "EUR")
        {
            Conversionnumber = .66645;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        };
    }
    else if (moneyType == "EUR")
    {
        if (moneyTypeConverting == "USD")
        {
            Conversionnumber = 1.19648;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "GBP")
        {
            Conversionnumber = .86826;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "CAN")
        {
            Conversionnumber = 1.50040;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        }
        else if (moneyTypeConverting == "EUR")
        {
            Conversionnumber = 1;

            result = Woody_Exchange.Exchanger.Multiply(moneyAmountConverted, Conversionnumber);

            saveResult = Woody_Exchange.ExchangeMonitor.AddResult(result, bean);

            bean = result;

            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("solution: " + result);

            Console.WriteLine("if you would like to do another, please say 'yes'");

            cont = Console.ReadLine();

            counter = Woody_Exchange.ExchangeMonitor.AddOne(counter);

            if (cont == "yes")
            {
                goto again;
            }
        };
    };
} while (cont == "yes");
Console.WriteLine("Amount of exchanges: " + counter + " Total money exchanged: " + saveResult);
