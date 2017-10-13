// #pragma strict

 private var speed = 2.0/4;
 
 function Update() {
     var angle = (Mathf.Sin(Time.time * speed) + 1.0) / 2.0 * 360.0;
     transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
 
 }


private var rotate = 1;
//private var speed2 = 0.5;

function Rot() {
    // var angle = (Mathf.Sin(Time.time * speed2) + 1.0) / 2.0 * 360.0;
    var angle = rotate * 90.0;    
    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    rotate++;
}


/* original code
private var rotate = 1;
private var speed = 0.5;

function Rot() {
    // var angle = (Mathf.Sin(Time.time * speed) + 1.0) / 2.0 * 360.0;
    var angle = rotate * 90.0;    
    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    rotate++;
}
*/