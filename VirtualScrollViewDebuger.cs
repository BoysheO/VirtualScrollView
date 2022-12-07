
using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

#pragma warning disable CS0108, CS0114
[RequireComponent(typeof(VirtualScrollView))]
public class VirtualScrollViewDebuger : MonoBehaviour
{
    [ShowInInspector] public VirtualScrollView View => GetComponent<VirtualScrollView>();

    [ShowInInspector]
    public UnityEngine.UI.VirtualScrollView.AttachSnap attachSnap
    {
        get => View.attachSnap;
        set => View.attachSnap=value;
    }
    [ShowInInspector]
    public System.Boolean autoAttach
    {
        get => View.autoAttach;
        set => View.autoAttach=value;
    }
    [ShowInInspector]
    public UnityEngine.RectTransform content
    {
        get => View.content;
        set => View.content=value;
    }
    [ShowInInspector]
    public System.Single decelerationRate
    {
        get => View.decelerationRate;
        set => View.decelerationRate=value;
    }
    [ShowInInspector]
    public System.Single elasticity
    {
        get => View.elasticity;
        set => View.elasticity=value;
    }
    [ShowInInspector]
    public System.Boolean enabled
    {
        get => View.enabled;
        set => View.enabled=value;
    }
    [ShowInInspector]
    public System.UInt32 fixedCount
    {
        get => View.fixedCount;
        set => View.fixedCount=value;
    }
    [ShowInInspector]
    public UnityEngine.GameObject gameObject
    {
        get => View.gameObject;
    }
    [ShowInInspector]
    public UnityEngine.HideFlags hideFlags
    {
        get => View.hideFlags;
        set => View.hideFlags=value;
    }
    [ShowInInspector]
    public System.Single horizontalNormalizedPosition
    {
        get => View.horizontalNormalizedPosition;
        set => View.horizontalNormalizedPosition=value;
    }
    [ShowInInspector]
    public UnityEngine.UI.Scrollbar horizontalScrollbar
    {
        get => View.horizontalScrollbar;
        set => View.horizontalScrollbar=value;
    }
    [ShowInInspector]
    public System.Single horizontalScrollbarSpacing
    {
        get => View.horizontalScrollbarSpacing;
        set => View.horizontalScrollbarSpacing=value;
    }
    [ShowInInspector]
    public UnityEngine.UI.VirtualScrollView.ScrollbarVisibility horizontalScrollbarVisibility
    {
        get => View.horizontalScrollbarVisibility;
        set => View.horizontalScrollbarVisibility=value;
    }
    [ShowInInspector]
    public System.Boolean inertia
    {
        get => View.inertia;
        set => View.inertia=value;
    }
    [ShowInInspector]
    public System.Boolean isActiveAndEnabled
    {
        get => View.isActiveAndEnabled;
    }
    [ShowInInspector]
    public UnityEngine.Vector2 itemSize
    {
        get => View.itemSize;
        set => View.itemSize=value;
    }
    [ShowInInspector]
    public System.Boolean loop
    {
        get => View.loop;
        set => View.loop=value;
    }
    [ShowInInspector]
    public UnityEngine.RectOffset margin
    {
        get => View.margin;
        set => View.margin=value;
    }
    [ShowInInspector]
    public UnityEngine.UI.VirtualScrollView.MotionType motionType
    {
        get => View.motionType;
        set => View.motionType=value;
    }
    [ShowInInspector]
    public UnityEngine.UI.VirtualScrollView.MovementType movementType
    {
        get => View.movementType;
        set => View.movementType=value;
    }
    [ShowInInspector]
    public System.String name
    {
        get => View.name;
        set => View.name=value;
    }
    [ShowInInspector]
    public UnityEngine.Vector2 normalizedPosition
    {
        get => View.normalizedPosition;
        set => View.normalizedPosition=value;
    }
    [ShowInInspector]
    public System.UInt32 numItems
    {
        get => View.numItems;
        set => View.numItems=value;
    }
    [ShowInInspector]
    public UnityEngine.UI.VirtualScrollView.ScrollRenderEvent onItemRender
    {
        get => View.onItemRender;
        set => View.onItemRender=value;
    }

    [ShowInInspector]
    public UnityEngine.UI.VirtualScrollView.ScrollRectEvent onValueChanged
    {
        get => View.onValueChanged;
        set => View.onValueChanged=value;
    }
    [ShowInInspector]
    public UnityEngine.RectTransform prefab
    {
        get => View.prefab;
        set => View.prefab=value;
    }

#if UNITY_EDITOR
    [ShowInInspector]
    public new System.Boolean runInEditMode
    {
        get => View.runInEditMode;
        set => View.runInEditMode=value;
    }
#endif

    [ShowInInspector]
    public UnityEngine.AnimationCurve scaleAnimation
    {
        get => View.scaleAnimation;
        set => View.scaleAnimation=value;
    }
    [ShowInInspector]
    public System.Boolean scaleCurve
    {
        get => View.scaleCurve;
        set => View.scaleCurve=value;
    }
    [ShowInInspector]
    public System.Single scrollSensitivity
    {
        get => View.scrollSensitivity;
        set => View.scrollSensitivity=value;
    }
    [ShowInInspector]
    public UnityEngine.Vector2 space
    {
        get => View.space;
        set => View.space=value;
    }
    [ShowInInspector]
    public System.String tag
    {
        get => View.tag;
        set => View.tag=value;
    }
    [ShowInInspector]
    public UnityEngine.Transform transform
    {
        get => View.transform;
    }
    [ShowInInspector]
    public System.Boolean useGUILayout
    {
        get => View.useGUILayout;
        set => View.useGUILayout=value;
    }
    [ShowInInspector]
    public UnityEngine.Vector2 velocity
    {
        get => View.velocity;
        set => View.velocity=value;
    }
    [ShowInInspector]
    public System.Single verticalNormalizedPosition
    {
        get => View.verticalNormalizedPosition;
        set => View.verticalNormalizedPosition=value;
    }
    [ShowInInspector]
    public UnityEngine.UI.Scrollbar verticalScrollbar
    {
        get => View.verticalScrollbar;
        set => View.verticalScrollbar=value;
    }
    [ShowInInspector]
    public System.Single verticalScrollbarSpacing
    {
        get => View.verticalScrollbarSpacing;
        set => View.verticalScrollbarSpacing=value;
    }
    [ShowInInspector]
    public UnityEngine.UI.VirtualScrollView.ScrollbarVisibility verticalScrollbarVisibility
    {
        get => View.verticalScrollbarVisibility;
        set => View.verticalScrollbarVisibility=value;
    }
    [ShowInInspector]
    public UnityEngine.RectTransform viewport
    {
        get => View.viewport;
        set => View.viewport=value;
    }
    [Button]
    public Boolean IsActive(){
        return View.IsActive();
    }
    [Button]
    public void StopMovement(){
         View.StopMovement();
    }
    [Button]
    public void SetLayoutHorizontal(){
         View.SetLayoutHorizontal();
    }
    [Button]
    public void SetLayoutVertical(){
         View.SetLayoutVertical();
    }

    [Button]
    public void BackTop(){
         View.BackTop();
    }
    [Button]
    public void ScrollTo(System.Int32 index,System.Single duration){
         View.ScrollTo(index,duration);
    }
    [Button]
    public void ScrollTo(System.Int32 index,System.Single duration,System.Single axis,System.IO.SeekOrigin seekOrigin){
         View.ScrollTo(index,duration,axis,seekOrigin);
    }
    [Button]
    public void ResetList(){
         View.ResetList();
    }
    [Button]
    public void RefreshList(){
         View.RefreshList();
    }
}
