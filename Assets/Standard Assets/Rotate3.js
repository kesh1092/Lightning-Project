// #pragma strict

 private var speed = 2.0/4;
 
 function Update() {
     var angle = (Mathf.Sin(Time.time * speed) + 1.0) / 2.0 * 360.0;
     transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
 
 }