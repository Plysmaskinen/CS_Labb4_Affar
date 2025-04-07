using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Labb4_Affar.Models;
using static System.Windows.Forms.LinkLabel;

namespace CS_Labb4_Affar.Controllers
{
    internal class DatabaseController
    {
        private List<Book> Books;
        private List<Game> Games;
        private List<Movie> Movies;
        public DatabaseController() { }

        public void InitDatabase()
        {

        }

        public void WriteDatabase() 
        { 
        
        }

        private List<Book> ReadBooks()
        {
            var books = new List<Book>();
            List<string> rows = ReadLinesFromCSV("books");

            rows.ForEach(row =>
            {
                string[] columns = row.Split(',');

            });

            return Books;
        }

        private void WriteBooks(List<Book> Books) { }
        private void ReadGames() { }
        private void WriteGames() { }
        private void ReadMovies() { }
        private void WriteMovies() { }

        private DataTable readCSVToDataTable()
        {
            DataTable dt = new DataTable();

            try
            {
                // Read all lines from the CSV
                string[] books = File.ReadAllLines("CSVDatabase\\books.csv");
                string[] games = File.ReadAllLines("CSVDatabase\\games.csv");
                string[] movies = File.ReadAllLines("CSVDatabase\\movies.csv");

                if (lines.Length > 0)
                {
                    // Split the first line (column headers) and create columns in the DataTable
                    string[] columns = lines[0].Split(',');

                    foreach (string column in columns)
                    {
                        dt.Columns.Add(column);
                    }

                    // Read the rest of the lines for data
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] row = lines[i].Split(',');
                        dt.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading CSV: " + ex.Message);
            }

            return dt;
        }

        private List<string> ReadLinesFromCSV(String FileName)
        {
            try
            {

                string[] rows = File.ReadAllLines("CSVDatabase\\" + FileName + ".csv");

                if (rows.Length > 1)
                {
                    var rowList = rows.ToList();

                    // Remove header row
                    rowList.RemoveAt(0);

                    return rowList;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading CSV: " + ex.Message);
            }

            return new List<string>();
        }

    }
}
