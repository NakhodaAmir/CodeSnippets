//Pseudocode
//Points p and q are represented as Vector3 variables where (p1, p2, p3) and (q1, q2, q3) = (p.x, p.y, p.z)
//and (q.x, q.y, q.z) respectively.
public float Distance(Vector3 p, Vector3 q)
{
	return  Math.Max(Math.Abs(p.x - q.x) + Math.Abs(p.y - q.y) + Math.Abs(p.z - q.z));
}
