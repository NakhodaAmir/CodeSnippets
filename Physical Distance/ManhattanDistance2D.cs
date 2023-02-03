//Pseudocode
//Points p and q are represented as Vector2 variables where (p1, p2) and (q1, q2) = (p.x, p.y) and (q.x, q.y) respectively.
public float Distance(Vector2 p, Vector2 q)
{
	return  Math.Abs(p.x - q.x) + Math.Abs(p.y - q.y);
}
