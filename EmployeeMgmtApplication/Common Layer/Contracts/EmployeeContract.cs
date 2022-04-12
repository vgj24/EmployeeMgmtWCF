﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common_Layer.Contracts
{
    [DataContract]
    public class EmployeeContract
    {
       [DataMember]
       public  int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Salary { get; set; }
        [DataMember]
        public string Email { get; set; }

    }
}
