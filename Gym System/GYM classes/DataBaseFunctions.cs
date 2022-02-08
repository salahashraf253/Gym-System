﻿using Gym_System.DataBase_Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Gym_System.GYM_classes
{
    internal class DataBaseFunctions
    {
        DataBase db = new DataBase();
        static string query;
        public DataTable viewMembersUnderCondition(string condition)
        {
            query = "select id,firstName,lastName,age,gender,phoneNumber,weight,membership from person" +
                " where type='member' ";
            if (condition != " ")
            {
                query = query +" "  + condition;
            }
            query += ";";
            DataTable dt = db.extractData(query);
            return dt;
        }

        public DataTable viewClasses() 
        {
            DataTable dt;
            query = "select name from class";
            dt=db.extractData(query);
            return dt;
        }
        public DataTable viewMembersWithSpecificClass()
        {
            query = "SELECT * FROM gym_data_base.person , gym_data_base.class " +
                "where gym_data_base.person.id = gym_data_base.class.trainerId;";
            DataTable dt = db.extractData(query);
            return dt;
        }
        public  void addPerson(string type,int id,string fName,string lName,string phoneNo,int age,string gender)
        {

            if (type == "member")//member
            {

            }
            else //trainer
            {
                db.insertData(type, id, fName, lName, phoneNo, age, gender, " ",0);
            }
        }
    }
}
