private void RunScript(double x, double y, double z, ref object A)
{
  Point3d pt = new Point3d();
  Sphere s;

  pt.X = x;
  pt.Y = y;
  pt.Z = z;

  s = new Sphere(pt, 20);
  A = s;

}