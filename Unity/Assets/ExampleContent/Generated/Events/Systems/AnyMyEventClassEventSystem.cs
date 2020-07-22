//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v1.2.0, branch:develop).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class AnyMyEventClassEventSystem : JCMG.EntitasRedux.ReactiveSystem<VisualDebugEntity> {

    readonly JCMG.EntitasRedux.IGroup<VisualDebugEntity> _listeners;
    readonly System.Collections.Generic.List<VisualDebugEntity> _entityBuffer;
    readonly System.Collections.Generic.List<IAnyMyEventClassListener> _listenerBuffer;

    public AnyMyEventClassEventSystem(Contexts contexts) : base(contexts.VisualDebug) {
        _listeners = contexts.VisualDebug.GetGroup(VisualDebugMatcher.AnyMyEventClassListener);
        _entityBuffer = new System.Collections.Generic.List<VisualDebugEntity>();
        _listenerBuffer = new System.Collections.Generic.List<IAnyMyEventClassListener>();
    }

    protected override JCMG.EntitasRedux.ICollector<VisualDebugEntity> GetTrigger(JCMG.EntitasRedux.IContext<VisualDebugEntity> context) {
        return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
            context, JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Added(VisualDebugMatcher.MyEventClass)
        );
    }

    protected override bool Filter(VisualDebugEntity entity) {
        return entity.HasMyEventClass;
    }

    protected override void Execute(System.Collections.Generic.List<VisualDebugEntity> entities) {
        foreach (var e in entities) {
            var component = e.MyEventClass;
            foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer)) {
                _listenerBuffer.Clear();
                _listenerBuffer.AddRange(listenerEntity.AnyMyEventClassListener.value);
                foreach (var listener in _listenerBuffer) {
                    listener.OnAnyMyEventClass(e, component.value);
                }
            }
        }
    }
}
