//Pseudocode
//Points p and q are represented as Vector3 variables where (p1, p2, p3) and (q1, q2, q3) = (p.x, p.y, p.z)
public float Distance(Vector3 p, Vector3 q)
{
	float dX = x∆;
	float dY = y∆;
	float dZ = z∆;

	//Function sorts the 3 delta distances and returns dmin, dmid and dmax which are the minimum delta distance, 
	//middle delta distance and max delta distance respectively
	Sort3(dX, dY, dZ, out float dmin, out float dmid, out float dmax);

	return (Math.Sqrt(3) - Math.Sqrt(2)) * dmin + (Math.Sqrt(2) - 1) * dmid + dmax;
}
