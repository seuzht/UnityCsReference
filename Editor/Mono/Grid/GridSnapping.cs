// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using UnityEngine;

namespace UnityEditor
{
    internal static class GridSnapping
    {
        public static Func<Vector3, Vector3> snapPosition;

        public static bool active
        {
            get { return snapPosition != null; }
        }

        public static Vector3 Snap(Vector3 position)
        {
            if (active)
                return snapPosition(position);
            return position;
        }
    }
}
