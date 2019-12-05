﻿using System;

namespace milktea.Entity
{
    public class Table
    {
        private String id;
        private int status;

        public Table()
        {
        }

        public Table(string id, int status)
        {
            this.id = id;
            this.status = status;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public int Status
        {
            get => status;
            set => status = value;
        }
    }
}