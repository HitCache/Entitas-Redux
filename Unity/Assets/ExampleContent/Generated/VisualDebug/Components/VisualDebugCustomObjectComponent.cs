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
	public ExampleContent.VisualDebugging.CustomObjectComponent CustomObject { get { return (ExampleContent.VisualDebugging.CustomObjectComponent)GetComponent(VisualDebugComponentsLookup.CustomObject); } }
	public bool HasCustomObject { get { return HasComponent(VisualDebugComponentsLookup.CustomObject); } }

	public void AddCustomObject(ExampleContent.VisualDebugging.CustomObject newCustomObject)
	{
		var index = VisualDebugComponentsLookup.CustomObject;
		var component = (ExampleContent.VisualDebugging.CustomObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.CustomObjectComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.customObject = newCustomObject;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceCustomObject(ExampleContent.VisualDebugging.CustomObject newCustomObject)
	{
		var index = VisualDebugComponentsLookup.CustomObject;
		var component = (ExampleContent.VisualDebugging.CustomObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.CustomObjectComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.customObject = newCustomObject;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyCustomObjectTo(ExampleContent.VisualDebugging.CustomObjectComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.CustomObject;
		var component = (ExampleContent.VisualDebugging.CustomObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.CustomObjectComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.customObject = (ExampleContent.VisualDebugging.CustomObject)copyComponent.customObject.Clone();
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveCustomObject()
	{
		RemoveComponent(VisualDebugComponentsLookup.CustomObject);
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
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherCustomObject;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> CustomObject
	{
		get
		{
			if (_matcherCustomObject == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.CustomObject);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherCustomObject = matcher;
			}

			return _matcherCustomObject;
		}
	}
}
