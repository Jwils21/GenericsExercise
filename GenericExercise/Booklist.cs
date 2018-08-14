using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExercise {
	public class Booklist {

		public void Add(Book book) {

		}

		public Book this[int index] {
			get { throw new NotImplementedException(); }

		}
	}
	

	public class GenericDictionary<TKey,Tvalue> {
		public void Add(TKey, Tvalue) {

		}
	}


	public class GenericList<T> {
		public void Add(T Value) {


		}
		public T this[int index] {
			get { throw new NotImplementedException(); }
		}

	}

}
