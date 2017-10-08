

private var rotate = 1;
private var speed = 0.5;

function Rot() {
    // var angle = (Mathf.Sin(Time.time * speed) + 1.0) / 2.0 * 360.0;
    var angle = rotate * 90.0;    
    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    rotate++;
}