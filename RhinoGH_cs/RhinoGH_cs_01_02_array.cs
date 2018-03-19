private void RunScript(object x, object y, ref object A)
{
  Point3d[] myPoints = new Point3d[10];
  for (int i = 0; i < myPoints.Length; i++){
    Point3d tempPt = new Point3d(i, i, 0);
    myPoints[i] = tempPt;
  }
  A = myPoints;

}