using System;
using System.Collections.Generic;
using TransportConsoleApp.crud;
using TransportConsoleApp.dictionary;
using TransportConsoleApp.json;
using TransportConsoleApp.model;
using static TransportConsoleApp.util.AppConstant;

namespace TransportConsoleApp.menu
{
    class StartMenu
    {
        private TransportCreate transportCreate;
        private TransportRemove transportRemove;
        private TransportUpdate transportUpdate;
        private TransportJsonUtil transportJsonUtil;

        public StartMenu() {
            transportCreate = new TransportCreate();
            transportRemove = new TransportRemove();
            transportUpdate = new TransportUpdate();
            transportJsonUtil = new TransportJsonUtil();
            showMenu();
        }

        private void showMenu()
        {
            bool exit = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Transport Console App Menu");
                Console.WriteLine(SHOW_ALL_TRANSPORT);
                Console.WriteLine(ADD_TRANSPORT);
                Console.WriteLine(EDIT_TRANSPORT);
                Console.WriteLine(REMOVE_TRANSPORT);
                Console.WriteLine(SAVE_ALL_TRANSPORT_TO_JSON);
                Console.WriteLine(READ_ALL_TRANSPORT_FROM_JSON);
                Console.WriteLine(EXIT);

                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine(SHOW_ALL_TRANSPORT + NEW_LINE);
                        ShowAllTransport();
                        Console.WriteLine(PRESS_ENTER);
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine(ADD_TRANSPORT + NEW_LINE);
                        AddTransport();
                        Console.WriteLine(PRESS_ENTER);
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine(EDIT_TRANSPORT + NEW_LINE);
                        UpdateTransport();
                        Console.WriteLine(PRESS_ENTER);
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine(REMOVE_TRANSPORT + NEW_LINE);
                        RemoveTransport();
                        Console.WriteLine(PRESS_ENTER);
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine(SAVE_ALL_TRANSPORT_TO_JSON + NEW_LINE);
                        SaveAllTransportToJson();
                        Console.WriteLine(PRESS_ENTER);
                        Console.ReadLine();
                        break;

                    case "6":
                        Console.WriteLine(READ_ALL_TRANSPORT_FROM_JSON + NEW_LINE);
                        ReadAllTransportFromJson();
                        Console.WriteLine(PRESS_ENTER);
                        Console.ReadLine();
                        break;

                    case "7":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }

            } while (!exit);
        }

        void ShowAllTransport()
        {
            List<Car> cars = Transport.Cars;
            for (int i = 0; i < cars.Count; i++)
            {
                Car car = cars[i];
                Console.Write(i + ". ");
                Console.WriteLine(car);
            }
        }

        void AddTransport()
        {
            Car car = transportCreate.Create();
            Transport.Cars.Add(car);
            Console.WriteLine("Car added: " + car);
        }

        void UpdateTransport()
        {
            transportUpdate.Update();
        }

        void RemoveTransport()
        {
            transportRemove.Remove();
        }

        void SaveAllTransportToJson()
        {
            transportJsonUtil.ToJson();
        }

        void ReadAllTransportFromJson()
        {
            transportJsonUtil.FromJson();
        }
    }
}
