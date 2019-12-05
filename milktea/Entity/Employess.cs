﻿using System;

namespace milktea.Entity
{
    public class Employess
    {
        private Int64 id;
        private String name;
        private DateTime birth;
        private String address;
        private String phone;
        private int idPosison;
        private String passsword;

        public Employess()
        {
        }

        public Employess(long id, string name, DateTime birth, string address, string phone, int idPosison, string passsword)
        {
            this.id = id;
            this.name = name;
            this.birth = birth;
            this.address = address;
            this.phone = phone;
            this.idPosison = idPosison;
            this.passsword = passsword;
        }

        public long Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime Birth
        {
            get => birth;
            set => birth = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public int IdPosison
        {
            get => idPosison;
            set => idPosison = value;
        }

        public string Passsword
        {
            get => passsword;
            set => passsword = value;
        }
    }
}