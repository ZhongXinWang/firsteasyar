/**
* Copyright (c) 2015-2016 VisionStar Information Technology (Shanghai) Co., Ltd. All Rights Reserved.
* EasyAR is the registered trademark or trademark of VisionStar Information Technology (Shanghai) Co., Ltd in China
* and other countries for the augmented reality technology developed by VisionStar Information Technology (Shanghai) Co., Ltd.
*/
using UnityEngine;
namespace EasyAR
{
    public class ImageTargetBehaviour : ImageTargetBaseBehaviour
    {

		protected override void Awake ()
		{
			base.Awake ();
			TargetFound += OnTargetFound;

		}

		void OnTargetFound(ImageTargetBaseBehaviour behaviour){


			Debug.Log ("Found"+Target.Id);
		

		}

		void onTargetLost(ImageTrackerBaseBehaviour behaviour){


			Debug.Log ("Lost:"+Target.Id);

		}


		void onTargetLoad(ImageTargetBaseBehaviour behaviour,ImageTrackerBaseBehaviour tracker,bool status){


			Debug.Log ("load Target("+status+")"+Target.Id+" ("+Target.Name+"->"+tracker);

		}
		
		void onTargetUnload(ImageTargetBaseBehaviour behaviour,ImageTrackerBaseBehaviour tracker,bool status){
			
			
			Debug.Log ("unload Target("+status+")"+Target.Id+" ("+Target.Name+"->"+tracker);
			
		}
    }
}
