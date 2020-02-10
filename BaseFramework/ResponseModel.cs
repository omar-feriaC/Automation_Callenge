using System;
using System.Collections.Generic;
using System.Text;

namespace BaseFramework.Model
{
    //We probably want to create data models for our different responses
    public class User
    {
        public UInt64 _id;
        public String UserName;
        public String Password;
        public String Authorization;
    }
    public class Error
    {

    }
    public class Task
    {
        public string task;
        public string data;
    }
    public class Message
    {

    }
}
