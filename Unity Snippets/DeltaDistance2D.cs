private static void DeltaDistance2D(Vector2 nodeA, Vector2 nodeB, out float dX, out float dY)
{
    dX = Math.Abs(nodeA.x - nodeB.x);
    dY = Math.Abs(nodeA.y - nodeB.y);
}
