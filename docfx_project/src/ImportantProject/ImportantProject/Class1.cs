using System;
using System.Collections.Generic;

/// <summary>
/// The namespace where it all begins.
/// </summary>
namespace ImportantProject
{
    public class Class1
    {
    }

    /// <summary>
    /// Base class to do work
    /// </summary>
    public abstract class M
    {
        /// <summary>
        /// Function that actually does the work
        /// </summary>
        protected abstract void doWork();
 
    }

    /// <summary>
    ///  This a very special type of <see cref="M"/>
    /// </summary>
    /// <typeparam name="T"> T or <see cref="T"/> can be anything you want.</typeparam>
    public abstract class M<T> : M where T : myInter
    {
        public float SomeProperty { get; set; }

        T myvar;

        Queue<T> list = new Queue<T>();

        /// <summary>
        /// Look at it. The <see cref="M.doWork"/> seems to be called into this mess.
        /// </summary>
        protected override void doWork()
        {
            myvar = list.Dequeue();
            Process(myvar);
        }

        /// <summary>
        ///  Lets a rpocess.
        /// </summary>
        /// <param name="input"> this is clearly the input</param>
        public abstract void Process(T input);

    }

    /// <summary>
    /// This is a nice interfac. you can use it for the stufzz
    /// </summary>
    public interface myInter
    {
        /// <summary>
    ///  this number apears to be important
    /// </summary>
        int ID { get; }
    }



}
