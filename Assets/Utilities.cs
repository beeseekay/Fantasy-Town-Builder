﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities {
	public static int ResourceCount(List<Resource> storage) {
		int sum = 0;
		foreach (Resource resource in storage) {
			sum += resource.count;
		}
		return sum;
	}

	public static Map map {
		get {
			return GameObject.Find("Map").GetComponent<Map>();
		}
	}

	public static MouseInput input {
		get {
			return GameObject.Find("Main Camera").GetComponent<MouseInput>();
		}
	}
}
