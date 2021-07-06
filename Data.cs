using System;
using System.Collections.Generic;
using System.IO;



namespace Capitals
{
    class Data
    {
        List<Country> countries = new List<Country>();
        String fileName = "countries_and_capitals.txt";

        public void getData()
        {
            String line;
            StreamReader sr = new StreamReader(fileName);
            while ((line = sr.ReadLine()) != null)
            {

                string[] s = line.Split("| ");
                var country = new Country
                {
                           name = s[0],
                           capital = s[1],
                    
                 };

                 //Console.WriteLine($"Państwo: {country.Name}, Stolica: {country.Capital}");
                 countries.Add(country);
                }
             sr.Close();

            }
        public List<Country> getCountries()
        {
            return countries;
        }
        public List<Country> deleteItem (int index)
        {
            countries.RemoveAt(index);
            return countries;
        }
    }
    }

