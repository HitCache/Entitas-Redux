//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebugEntity
{
	public PositionComponent Position { get { return (PositionComponent)GetComponent(VisualDebugComponentsLookup.Position); } }
	public bool HasPosition { get { return HasComponent(VisualDebugComponentsLookup.Position); } }

	public void AddPosition(ExampleContent.VisualDebugging.IntVector2 newValue)
	{
		var index = VisualDebugComponentsLookup.Position;
		var component = (PositionComponent)CreateComponent(index, typeof(PositionComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplacePosition(ExampleContent.VisualDebugging.IntVector2 newValue)
	{
		var index = VisualDebugComponentsLookup.Position;
		var component = (PositionComponent)CreateComponent(index, typeof(PositionComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyPositionTo(PositionComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.Position;
		var component = (PositionComponent)CreateComponent(index, typeof(PositionComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemovePosition()
	{
		RemoveComponent(VisualDebugComponentsLookup.Position);
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.2.1.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherPosition;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Position
	{
		get
		{
			if (_matcherPosition == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Position);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherPosition = matcher;
			}

			return _matcherPosition;
		}
	}
}
