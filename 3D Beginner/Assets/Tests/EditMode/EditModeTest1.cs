﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class EditModeTest1
    {
        // A Test behaves as an ordinary method
        [Test]
        public void EditModeTest1SimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator EditModeTest1WithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            var go = new GameObject();
            go.AddComponent<Rigidbody>();
            var originalPosition = go.transform.position.y;

            yield return new WaitForFixedUpdate();

            Assert.AreNotEqual(originalPosition, go.transform.position.y);
        }
    }
}
