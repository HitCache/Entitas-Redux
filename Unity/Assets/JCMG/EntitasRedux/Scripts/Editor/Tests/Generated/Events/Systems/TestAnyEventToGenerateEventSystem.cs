//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class TestAnyEventToGenerateEventSystem : JCMG.EntitasRedux.ReactiveSystem<TestEntity> {

    readonly JCMG.EntitasRedux.IGroup<TestEntity> _listeners;
    readonly System.Collections.Generic.List<TestEntity> _entityBuffer;
    readonly System.Collections.Generic.List<ITestAnyEventToGenerateListener> _listenerBuffer;

    public TestAnyEventToGenerateEventSystem(Contexts contexts) : base(contexts.Test) {
        _listeners = contexts.Test.GetGroup(TestMatcher.TestAnyEventToGenerateListener);
        _entityBuffer = new System.Collections.Generic.List<TestEntity>();
        _listenerBuffer = new System.Collections.Generic.List<ITestAnyEventToGenerateListener>();
    }

    protected override JCMG.EntitasRedux.ICollector<TestEntity> GetTrigger(JCMG.EntitasRedux.IContext<TestEntity> context) {
        return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
            context, JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Added(TestMatcher.EventToGenerate)
        );
    }

    protected override bool Filter(TestEntity entity) {
        return entity.HasEventToGenerate;
    }

    protected override void Execute(System.Collections.Generic.List<TestEntity> entities) {
        foreach (var e in entities) {
            var component = e.EventToGenerate;
            foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer)) {
                _listenerBuffer.Clear();
                _listenerBuffer.AddRange(listenerEntity.TestAnyEventToGenerateListener.value);
                foreach (var listener in _listenerBuffer) {
                    listener.OnAnyEventToGenerate(e, component.value);
                }
            }
        }
    }
}
