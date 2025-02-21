//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class TestMultipleEventsStandardEventRemovedEventSystem : JCMG.EntitasRedux.ReactiveSystem<TestEntity>
{
	readonly System.Collections.Generic.List<ITestMultipleEventsStandardEventRemovedListener> _listenerBuffer;

	public TestMultipleEventsStandardEventRemovedEventSystem(Contexts contexts) : base(contexts.Test)
	{
		_listenerBuffer = new System.Collections.Generic.List<ITestMultipleEventsStandardEventRemovedListener>();
	}

	protected override JCMG.EntitasRedux.ICollector<TestEntity> GetTrigger(JCMG.EntitasRedux.IContext<TestEntity> context)
	{
		return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
			context,
			JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Removed(TestMatcher.MultipleEventsStandardEvent)
		);
	}

	protected override bool Filter(TestEntity entity)
	{
		return !entity.HasMultipleEventsStandardEvent && entity.HasTestMultipleEventsStandardEventRemovedListener;
	}

	protected override void Execute(System.Collections.Generic.List<TestEntity> entities)
	{
		foreach (var e in entities)
		{
			
			_listenerBuffer.Clear();
			_listenerBuffer.AddRange(e.TestMultipleEventsStandardEventRemovedListener.value);
			foreach (var listener in _listenerBuffer)
			{
				listener.OnMultipleEventsStandardEventRemoved(e);
			}
		}
	}
}
