
using System;
using System.Collections.Generic;
using XLua;
using UnityEngine;
using UnityEngine.Video;


/// <summary>
/// UnityEngine 代码生成配置
/// </summary>
public static class LuaFrameworkConfig_UnityEngine
{

    [CSharpCallLua]
    public static List<Type> CSharpCallLua = new List<Type>()
    {
        typeof(VideoPlayer.EventHandler),
        typeof(VideoPlayer.FrameReadyEventHandler),
        typeof(VideoPlayer.TimeEventHandler),
        typeof(VideoPlayer.ErrorEventHandler),
    };

    [LuaCallCSharp]
    public static List<Type> LuaCallCSharp = new List<Type>()
    {

        typeof(UnityEngine.Object),
                typeof(Vector2),
                typeof(Vector3),
                typeof(Vector4),
                typeof(Quaternion),
                typeof(Color),
                typeof(Ray),
                typeof(Bounds),
                typeof(Ray2D),
                typeof(Time),
                typeof(GameObject),
                typeof(Component),
                typeof(Behaviour),
                typeof(Transform),
                typeof(Resources),
                typeof(TextAsset),
                typeof(Keyframe),
                typeof(AnimationCurve),
                typeof(AnimationClip),
                typeof(MonoBehaviour),
                typeof(ParticleSystem),
                typeof(SkinnedMeshRenderer),
                typeof(Renderer),
                typeof(Light),
                typeof(Mathf),
                typeof(Debug),
                typeof(VideoPlayer),
                typeof(RenderTexture),
                typeof(AudioSource),
                typeof(AudioClip),
                typeof(Texture2D),
        //(typeof(Component)),
        //(typeof(Transform)),
        //(typeof(Material)),
        //(typeof(Light)),
        //(typeof(Rigidbody)),
        //(typeof(Camera)),
        //(typeof(List<Camera>)),
        //(typeof(UniversalAdditionalCameraData)),
        //(typeof(CameraRenderType)),
        //(typeof(AudioBehaviour)),
        //(typeof(AudioSource)),
        //(typeof(AudioListener)),
        //(typeof(Behaviour)),
        //(typeof(MonoBehaviour)),
        //(typeof(GameObject)),
        //(typeof(UnityEngine.Object)),
        //(typeof(SystemInfo)),
        //(typeof(TrackedReference)),
        //(typeof(Application)),
        //(typeof(Physics)),
        //(typeof(Collider)),
        //(typeof(Time)),
        //(typeof(Texture)),
        //(typeof(Texture2D)),
        //(typeof(Shader)),
        //(typeof(Renderer)),
        //(typeof(UnityWebRequest)),
        //(typeof(Screen)),
        //(typeof(CameraClearFlags)),
        //(typeof(AudioClip)),
        //(typeof(AssetBundle)),
        ////(typeof(ParticleSystem)),
        //(typeof(AsyncOperation)),
        //(typeof(LightType)),
        //(typeof(SleepTimeout)),
        //(typeof(VideoPlayer)),
        //(typeof(VideoAudioOutputMode)),
        //        (typeof(Animator)),
        //(typeof(RuntimeAnimatorController)),
        //(typeof(Spine.AnimationStateData)), // spine
        //(typeof(AnimatorClipInfo)),
        //(typeof(Input)),
        //(typeof(KeyCode)),
        //(typeof(SkinnedMeshRenderer)),
        //(typeof(Space)),
        //(typeof(AnimationCurve)),
        //        (typeof(RuntimePlatform)),
        //(typeof(BoxCollider)),
        //(typeof(MeshCollider)),
        //(typeof(SphereCollider)),
        //(typeof(CharacterController)),
        //(typeof(CapsuleCollider)),

        //(typeof(Animation)),
        //(typeof(AnimationClip)),
        //(typeof(AnimationState)),
        //(typeof(AnimationBlendMode)),
        //(typeof(QueueMode)),
        //(typeof(PlayMode)),
        //(typeof(WrapMode)),

        //(typeof(QualitySettings)),
        //(typeof(RenderSettings)),
        //(typeof(SkinWeights)),
        //(typeof(RenderTexture)),
        //(typeof(Resources)),

        //(typeof(Rect)),
        //(typeof(RectTransform)),
        //(typeof(UIBehaviour)),
        //(typeof(Selectable)),
        //(typeof(Button)),
        //(typeof(CanvasGroup)),
        //(typeof(CanvasScaler)),
        //(typeof(UnityEventBase)),
        //(typeof(UnityEvent)),
        //(typeof(UnityEvent<float>)),
        //(typeof(UnityEvent<bool>)),
        //(typeof(ToggleGroup)),
        //(typeof(Toggle)),
        //(typeof(Slider)),
        //(typeof(Graphic)),
        //(typeof(MaskableGraphic)),
        //(typeof(Text)),
        //(typeof(Image)),
        //(typeof(SpriteMask)),
        //(typeof(InputField)),
        //(typeof(Sprite)),
        //(typeof(RawImage)),
        //(typeof(ContentSizeFitter)),
        //(typeof(ScrollRect)),
        //(typeof(SpriteAtlas)),
        //(typeof(AnimationReferenceAsset)),
        //(typeof(ScriptableObject)),
        //(typeof(PlayableDirector)),
        //(typeof(VideoClip)),
        //(typeof(Dropdown)),
        //(typeof(Dropdown.DropdownEvent)),
        //(typeof(PlayerPrefs)),
        //(typeof(TimeSpan)),
        //(typeof(SceneManager)),
        //(typeof(GC)),
        //(typeof(Canvas)),
        //(typeof(RenderMode)),
        //(typeof(LayoutRebuilder)),
        //(typeof(RectTransformUtility)),
        //(typeof(List<int>)),
        //(typeof(List<string>)),
        //(typeof(List<float>)),
        //(typeof(List<Vector3>)),
        //(typeof(VerticalLayoutGroup)),
        //(typeof(DateTime)),
        //(typeof(TextMesh)),
    };

    //黑名单
    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
                new List<string>(){"System.Xml.XmlNodeList", "ItemOf"},
                new List<string>(){"UnityEngine.WWW", "movie"},
    #if UNITY_WEBGL
                new List<string>(){"UnityEngine.WWW", "threadPriority"},
    #endif
                new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
                new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue"},
                new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
                new List<string>(){"UnityEngine.Light", "areaSize"},
                new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
                new List<string>(){"UnityEngine.Light", "SetLightDirty"},
                new List<string>(){"UnityEngine.Light", "shadowRadius"},
                new List<string>(){"UnityEngine.Light", "shadowAngle"},
    #if UNITY_ANDROID

    #endif
                new List<string>(){"UnityEngine.WWW", "MovieTexture"},
                new List<string>(){"UnityEngine.WWW", "GetMovieTexture"},
                new List<string>(){"UnityEngine.AnimatorOverrideController", "PerformOverrideClipListCleanup"},
    #if !UNITY_WEBPLAYER
                new List<string>(){"UnityEngine.Application", "ExternalEval"},
    #endif
                new List<string>(){"UnityEngine.GameObject", "networkView"}, //4.6.2 not support
                new List<string>(){"UnityEngine.Component", "networkView"},  //4.6.2 not support
                new List<string>(){"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "CreateSubdirectory", "System.String", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"UnityEngine.MonoBehaviour", "runInEditMode"},
            };

}