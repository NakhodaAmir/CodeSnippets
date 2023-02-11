private static void DeltaDistance2D(Vector2 nodeA, Vector2 nodeB, out float dX, out float dY)
{
    dX = Math.Abs(nodeA.x - nodeB.x);
    dY = Math.Abs(nodeA.y - nodeB.y);
}

public static void DeltaDistance3D(Vector3 nodeA, Vector3 nodeB, out float dX, out float dY, out float dZ)
{
    DeltaDistance2D(nodeA, nodeB, out dX, out dY);

    dZ = Math.Abs(nodeA.z - nodeB.z);
}
