﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class ExportSTLTool : Tool {

	protected override void OnActivate() {
		StopTool();
		var data = Sketch.instance.ExportSTL(); 
		NoteCADJS.SaveData(data, "NoteCADExport.stl");
	}
}