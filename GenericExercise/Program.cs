﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExercise {
	class Program {


		static void Main(string[] args) {

			var book = new Book { ISBN = "1111", Title = "C# Advanced" };

			var numbers = new GenericList<int>();
			numbers.Add(10);

			var books = new GenericList<Book>();
			books.Add(new Book());
			
			var dictionary = new GenericDictionary<string, Book>();
			dictionary.Add("1234", new Book());
		}
	}
}
