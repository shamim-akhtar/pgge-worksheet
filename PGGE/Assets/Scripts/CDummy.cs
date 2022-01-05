using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TPCBase
{
  protected Transform mCameraTransform;
  protected Transform mPlayerTransform;
  public TPCBase(Transform player, Transform camera)
  {
    mPlayerTransform = player;
    mCameraTransform = camera;
  }

  public abstract void Update();

}

public class TPCTrack : TPCBase
{
  public TPCTrack(Transform player, Transform camera)
    : base(player, camera)
  {
  }
  public override void Update()
  {

  }
}

public class CDummy : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    TPCBase tpc = new TPCTrack(Camera.main.transform, transform);
  }

  // Update is called once per frame
  void Update()
  {

  }
}
