using System;

/// <summary>
/// The sequel
/// </summary>
namespace ImportantProject.SubNS
{
    /// <summary>
    /// this is a clss using <seealso cref="myInter"/>
    /// </summary>
    public class Cenas : myInter
    {
        /// <summary>
        /// USing ID from <see cref="myInter"/> and it looks like you can get set now.
        /// </summary>
        public int ID { get; set; }
    }

    /// <summary>
    /// cool cool mas com <see cref="M"/> or <seealso cref="M{T}"/> or even <see cref="Cenas"/>
    /// </summary>
    public class Mod : M<Cenas>
    {
        /// <summary>
        /// vroom vroom processing.
        /// </summary>
        /// <param name="input"></param>
        public override void Process(Cenas input)
        {
            
        }
    }
}
