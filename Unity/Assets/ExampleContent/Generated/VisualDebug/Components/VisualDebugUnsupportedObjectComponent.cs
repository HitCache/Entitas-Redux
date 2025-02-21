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
	public ExampleContent.VisualDebugging.UnsupportedObjectComponent UnsupportedObject { get { return (ExampleContent.VisualDebugging.UnsupportedObjectComponent)GetComponent(VisualDebugComponentsLookup.UnsupportedObject); } }
	public bool HasUnsupportedObject { get { return HasComponent(VisualDebugComponentsLookup.UnsupportedObject); } }

	public void AddUnsupportedObject(ExampleContent.VisualDebugging.UnsupportedObject newUnsupportedObject)
	{
		var index = VisualDebugComponentsLookup.UnsupportedObject;
		var component = (ExampleContent.VisualDebugging.UnsupportedObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.UnsupportedObjectComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.unsupportedObject = newUnsupportedObject;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceUnsupportedObject(ExampleContent.VisualDebugging.UnsupportedObject newUnsupportedObject)
	{
		var index = VisualDebugComponentsLookup.UnsupportedObject;
		var component = (ExampleContent.VisualDebugging.UnsupportedObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.UnsupportedObjectComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.unsupportedObject = newUnsupportedObject;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyUnsupportedObjectTo(ExampleContent.VisualDebugging.UnsupportedObjectComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.UnsupportedObject;
		var component = (ExampleContent.VisualDebugging.UnsupportedObjectComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.UnsupportedObjectComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.unsupportedObject = (ExampleContent.VisualDebugging.UnsupportedObject)copyComponent.unsupportedObject.Clone();
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveUnsupportedObject()
	{
		RemoveComponent(VisualDebugComponentsLookup.UnsupportedObject);
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
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherUnsupportedObject;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> UnsupportedObject
	{
		get
		{
			if (_matcherUnsupportedObject == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.UnsupportedObject);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherUnsupportedObject = matcher;
			}

			return _matcherUnsupportedObject;
		}
	}
}
