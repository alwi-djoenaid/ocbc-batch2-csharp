using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Assignment10.Models
{
    public class MovieContext
    {
        public string ConnectionString { get; set; }

        public MovieContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MovieItem> getAllMovie()
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movies", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetInt32("duration"),
                            releaseDate = reader.GetDateTime("release_date")
                        });
                    }
                    conn.Close();
                }
                return list;
            }
        }

        public List<MovieItem> getMovieById(int id)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movies WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetInt32("duration"),
                            releaseDate = reader.GetDateTime("release_date")
                        });
                    }
                }
                conn.Close();
            }

            return list;
        }

        public List<MovieItem> InsertMovie(MovieItem movie)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO movies (name, genre, duration, release_date) " +
                    "VALUES (@name, @genre, @duration, @releaseDate)", conn);
                cmd.Parameters.AddWithValue("@name", movie.name);
                cmd.Parameters.AddWithValue("@genre", movie.genre);
                cmd.Parameters.AddWithValue("@duration", movie.duration);
                cmd.Parameters.AddWithValue("@releaseDate", movie.releaseDate);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetInt32("duration"),
                            releaseDate = reader.GetDateTime("release_date")
                        });
                    }
                }

                conn.Close();

                return list;
            }
        }

        public List<MovieItem> UpdateMovie(int id, MovieItem movie)
        {
            List<MovieItem> list = new List<MovieItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE movies " +
                    "SET name=@name, " +
                    "genre=@genre, " +
                    "duration=@duration, " +
                    "release_date=@releaseDate " +
                    "WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", movie.id);
                cmd.Parameters.AddWithValue("@name", movie.name);
                cmd.Parameters.AddWithValue("@genre", movie.genre);
                cmd.Parameters.AddWithValue("@duration", movie.duration);
                cmd.Parameters.AddWithValue("@releaseDate", movie.releaseDate);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            genre = reader.GetString("genre"),
                            duration = reader.GetInt32("duration"),
                            releaseDate = reader.GetDateTime("release_date")
                        });
                    }
                }

                conn.Close();

                return list;
            }
        }

        public bool DeleteMovie(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                var isExist = getMovieById(id).Count != 0;

                if (isExist)
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM movies WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    var deletedMovie = getMovieById(id);

                    if (deletedMovie.Count == 0)
                    {
                        return true;
                    }
                    else return false;

                    
                }
                return false;
            }
        }
    }
}
