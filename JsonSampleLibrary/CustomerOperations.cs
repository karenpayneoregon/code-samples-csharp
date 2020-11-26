using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using JsonSampleLibrary.Classes;
using JsonSampleLibrary.Models;
using static System.Reflection.MethodBase;

namespace JsonSampleLibrary
{
    public class CustomerOperations
    {
        public delegate void OnException(DeserializeException container);
        /// <summary>
        /// Callback for subscribers to know about a problem
        /// </summary>
        public static event OnException OnExceptionEvent;

        public static string FileName = "customers.json";
        public static List<Customer> GeTopCustomers(int count)
        {
            try
            {
                var json = File.ReadAllText(FileName);
                var customers = JsonSerializer.Deserialize<List<Customer>>(json).Take(count).ToList();
                return customers;
            }
            catch (Exception ex)
            {
                OnExceptionEvent?.Invoke(new DeserializeException()
                {
                    MethodName = $"{GetCurrentMethod().DeclaringType}.{GetCurrentMethod().Name}",
                    Exception = ex
                });

                return null;
            }
        }

        public static List<Customer> IgnoreNullValuesTest(int count) 
        {
            try
            {
                var json = File.ReadAllText(FileName);
                var customers = JsonSerializer.Deserialize<List<Customer>>(json, new JsonSerializerOptions { IgnoreNullValues = true }).Take(count).ToList();
                return customers;
            }
            catch (Exception ex)
            {
                OnExceptionEvent?.Invoke(new DeserializeException()
                {
                    MethodName = $"{GetCurrentMethod().DeclaringType}.{GetCurrentMethod().Name}",
                    Exception = ex
                });

                return null;
            }
        }

        public static List<Customer> GeCustomers()
        {
            try
            {
                var fileName = "customers.json";
                var json = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<List<Customer>>(json).ToList();
            }
            catch (Exception ex)
            {
                OnExceptionEvent?.Invoke(new DeserializeException()
                {
                    MethodName = $"{GetCurrentMethod().DeclaringType}.{GetCurrentMethod().Name}",
                    Exception = ex
                });

                return null;
            }
        }
    }
}
