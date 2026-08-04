using UnityEngine;

namespace GameDevTV.Saving
{
    /*
     * Unity cannot serialize Vector3s.  This will take a Vector3
     * and turn it into 3 floats which can be serialized.  If going
     * the other direction, it takes 3 floats and turns them into
     * a Vector3.
    */
    /// <summary>
    /// A `System.Serializable` wrapper for the `Vector3` class.
    /// </summary>
    [System.Serializable]
    public class SerializableVector3
    {
        float x, y, z;

        /// <summary>
        /// Copy over the state from an existing Vector3.
        /// </summary>
        /// 
        /*
         * Takes Vector3 and breaks it into 3 floats
        */
        public SerializableVector3(Vector3 vector)
        {
            x = vector.x;
            y = vector.y;
            z = vector.z;
        }

        /// <summary>
        /// Create a Vector3 from this class' state.
        /// </summary>
        /// <returns></returns>
        /*
         * Takes 3 floats and turns them into a Vector3
        */
        public Vector3 ToVector()
        {
            return new Vector3(x, y, z);
        }
    }
}