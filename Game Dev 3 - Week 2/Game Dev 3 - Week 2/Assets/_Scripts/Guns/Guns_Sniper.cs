using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDevWithMarco.Guns
{
    public class Guns_Sniper : Guns_Parent
    {
        // Start is called before the first frame update
        public override void GunSound()
        {
            //To randomise the pitch between 2 values
            gunAudioSource.pitch = Random.Range(0.6f, 1.4f);
            //To play the sound once
            gunAudioSource.PlayOneShot(gunSound);
        }

        public override void MuzzleFlash()
        {
            //Will loop through the whole array   
            base.MuzzleFlash();
        }
    }
}
