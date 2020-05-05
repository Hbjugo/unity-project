﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Save {
	// Party position on the map
	public int partyCellX;
	public int partyCellY;
	public string currPlace;

	// Current state of the Quest log
	public Dictionary<string, bool> log = new Dictionary<string, bool>();
	public Dictionary<string, string> trivGiven = new Dictionary<string, string>();
	public string pendingQuestID;

	// Current state of the cities
	public Dictionary<string, List<string>> placesObjQuests = new Dictionary<string, List<string>>();
	public Dictionary<string, List<string>> placesRecQuests = new Dictionary<string, List<string>>();
	public Dictionary<string, bool> activatedPlaces = new Dictionary<string, bool>();

}
