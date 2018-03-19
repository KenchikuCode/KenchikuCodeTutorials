private void RunScript(List<Point3d> pts, ref object A)
{
  Line[] ln = new Line[pts.Count()];

  for (int i = 0; i < pts.Count(); i++){
    int friend = i;
    double closest = 10000;
    for (int j = 0; j < pts.Count(); j++){
      if (j != i){
        double dist = pts[i].DistanceTo(pts[j]);
        if (dist < closest) {
          closest = dist;
          friend = j;
        }
      }
    }
    ln[i] = new Line(pts[i], pts[friend]);
  }
  A = ln;
  
}
