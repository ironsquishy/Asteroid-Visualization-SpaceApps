//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;


public class ThreadJob
	{	
		private bool m_IsDone = false;
		private object m_Handle = new object();
		private System.Threading.Thread m_Thread = null;

		public ThreadJob ()
		{

		}

		public bool IsDone
		{
			get
			{
				bool tmp;
				lock (m_Handle)
				{
					tmp = m_IsDone;
				}
				return tmp;
			}
			set
			{
				lock (m_Handle)
				{
					m_IsDone = value;
				}
			}
		}

		public virtual void Start()
		{
			m_Thread = new System.Threading.Thread(Run);
			m_Thread.Start();
		}
		public virtual void Abort()
		{
			m_Thread.Abort();
		}
		
		protected virtual void ThreadFunction() { }
		
		protected virtual void OnFinished() { }
		
		public virtual bool Update()
		{
			if (IsDone)
			{
				OnFinished();
				return true;
			}
			return false;
		}
		private void Run()
		{
			ThreadFunction();
			IsDone = true;
		}
	}


