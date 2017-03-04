using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators2 : MonoBehaviour {

//public string numbers1;
//public string numbers2;
public int myInt;
public int myInt2;

//public void OnButtonClick () {
//		if(numbers1 == "1" && numbers2 == "2")
//		{
//			print("One and Two are here.");
//		}
//		if(numbers1 == "1" || numbers2 == "2")
//		{
//			print("One or Two is here.");
//		}
//		if(numbers1 != "1" && numbers2 != "2");
//		{
//			print("No one is here.");
//		}
//	}
public void ClickInt () {
		if(myInt == "5" && myInt2 == "5")
		{
			print("Both of them are five!");
		}
		if(myInt == "5" || myInt2 != "5")
			{
				print("Only one of these is five!");
			}
		if(myInt != "5" && myInt2 != "5")
		{
			print("Nothing here is a five.");
		}
		}
}
