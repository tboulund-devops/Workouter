﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class WorkoutDatabase
    {
        public static IDbConnection GetConnection()
        {
            return new SqlConnection("Server=localhost;Database=Workouter;User Id=sa;Password=HelloW0rld;");
        }
    }
}
