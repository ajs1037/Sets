using System;
using System.Collections.Generic;

/*
 *
 * Adolfo Segura
 * Ajs1037
 * Last Edit: 10/09/17
 * 
 */

namespace SetRunner {
    class MainClass {
        
        public static void Main(string[] args) {

			// create list one and add letters
			List<string> set1 = new List<string>();
            set1.Add("a");
			set1.Add("b");
			set1.Add("c");
			set1.Add("d");
			set1.Add("e");

			// create list two and add letters
			List<string> set2 = new List<string>();
			set2.Add("a");
			set2.Add("b");
			set2.Add("c");
			set2.Add("d");
			set2.Add("e");
			set2.Add("f");
			set2.Add("g");
			set2.Add("h");

            Console.Write("Intersection: ");
            print(Intersection(set1, set2));

            Console.Write("Union: ");
            print(Union(set1, set2));

			Console.Write("Difference A - B: ");
			print(DifferenceAB(set1, set2));

			Console.Write("Difference B - A: ");
			print(DifferenceBA(set1, set2));

        }
        // Intersection of set1 and set2
        public static List<string> Intersection(List<string> A, List<string> B) {
			List<string> result = new List<string>();
			var arr1 = A.ToArray();
			var arr2 = B.ToArray();
			int i = 0;
			int j = 0;

			while (i < arr1.Length && j < arr2.Length) {
				if (arr1[i].CompareTo(arr2[j]) == 0) {
					result.Add(arr1[i]);
					i++;
					j++;
				}
				else if (arr1[i].CompareTo(arr2[j]) > 0) {
					j++;
				}
				else {
					i++;
				}
			}
            return result;
        }

		// Difference of set1 - set2
		public static List<string> DifferenceAB(List<string> u1, List<string> u2) {
			List<string> result = new List<string>();
            List<string> temp = new List<string>();
			var arr1 = u1.ToArray();
			var arr2 = u2.ToArray();

			for (int i = 0; i < arr1.Length; i++) {
				if (result.Contains(arr1[i])) {

				}
				else {
					result.Add(arr1[i]);
				}
			}
			for (int j = 0; j < arr2.Length; j++) {
				if (result.Contains(arr2[j])) {
                    result.Remove(arr2[j]);
				}
				else {
					//result.Add(arr2[j]);
				}
			}
			return result;
		}

		// Difference of set2 - set1
		public static List<string> DifferenceBA(List<string> u1, List<string> u2) {
			List<string> result = new List<string>();
			List<string> temp = new List<string>();
			var arr1 = u1.ToArray();
			var arr2 = u2.ToArray();

			for (int i = 0; i < arr1.Length; i++) {
				if (result.Contains(arr1[i])) {

				}
				else {
					result.Add(arr1[i]);
				}
			}
			for (int j = 0; j < arr2.Length; j++) {
				if (result.Contains(arr2[j])) {
					result.Remove(arr2[j]);
				}
				else {
					result.Add(arr2[j]);
				}
			}
			return result;
		}

		// Union of set1 and set2
		public static List<string> Union(List<string> d1, List<string> d2) {
			List<string> result = new List<string>();
			var arr1 = d1.ToArray();
			var arr2 = d2.ToArray();

            for (int i = 0; i < arr1.Length; i++) {
                if (result.Contains(arr1[i])) {
                    
                }
                else {
                    result.Add(arr1[i]);
                }
			}
			for (int j = 0; j < arr2.Length; j++) {
				if (result.Contains(arr2[j])) {

				}
				else {
                     result.Add(arr2[j]);
				}
			}
			return result;
		}

		// print final set
		public static void print(List<string> A) {
            var arr1 = A.ToArray();
            for (int i = 0; i < arr1.Length; i++) {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine(" ");
        }



    }

}
