using System.Runtime.InteropServices;

// generated
internal static partial class IL2cpp
{
    public const string GameAssembly = "GameAssembly";

    // init / shutdown
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_init")]
    public static partial void Init([MarshalAs(UnmanagedType.LPStr)] string domain_name);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_init_utf16")]
    public static partial void InitUtf16(IntPtr domain_name);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_shutdown")]
    public static partial void Shutdown();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_dumping_memory")]
    public static partial void DumpingMemory([MarshalAs(UnmanagedType.I1)] bool val);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_set_config_dir")]
    public static partial void SetConfigDir([MarshalAs(UnmanagedType.LPStr)] string config_path);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_set_data_dir")]
    public static partial void SetDataDir([MarshalAs(UnmanagedType.LPStr)] string data_path);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_set_temp_dir")]
    public static partial void SetTempDir([MarshalAs(UnmanagedType.LPStr)] string temp_path);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_set_commandline_arguments")]
    public static partial void SetCommandlineArguments(int argc, IntPtr argv, [MarshalAs(UnmanagedType.LPStr)] string basedir);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_set_commandline_arguments_utf16")]
    public static partial void SetCommandlineArgumentsUtf16(int argc, IntPtr argv, [MarshalAs(UnmanagedType.LPStr)] string basedir);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_set_config_utf16")]
    public static partial void SetConfigUtf16(IntPtr executablePath);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_set_config")]
    public static partial void SetConfig([MarshalAs(UnmanagedType.LPStr)] string executablePath);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_set_memory_callbacks")]
    public static partial void SetMemoryCallbacks(IntPtr callbacks);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_get_corlib")]
    public static partial IntPtr GetCorlib();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_add_internal_call")]
    public static partial void AddInternalCall([MarshalAs(UnmanagedType.LPStr)] string name, IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_resolve_icall")]
    public static partial IntPtr ResolveIcall([MarshalAs(UnmanagedType.LPStr)] string name);

    // memory
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_alloc")]
    public static partial IntPtr Alloc(nuint size);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_free")]
    public static partial void Free(IntPtr ptr);

    // array
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_array_class_get")]
    public static partial IntPtr ArrayClassGet(IntPtr element_class, uint rank);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_array_length")]
    public static partial uint ArrayLength(IntPtr array);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_array_get_byte_length")]
    public static partial uint ArrayGetByteLength(IntPtr array);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_array_new")]
    public static partial IntPtr ArrayNew(IntPtr elementTypeInfo, nuint length);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_array_new_specific")]
    public static partial IntPtr ArrayNewSpecific(IntPtr arrayTypeInfo, nuint length);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_array_new_full")]
    public static partial IntPtr ArrayNewFull(IntPtr array_class, IntPtr lengths, IntPtr lower_bounds);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_bounded_array_class_get")]
    public static partial IntPtr BoundedArrayClassGet(IntPtr element_class, uint rank, [MarshalAs(UnmanagedType.I1)] bool bounded);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_array_element_size")]
    public static partial int ArrayElementSize(IntPtr array_class);

    // assembly / image
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_assembly_get_image")]
    public static partial IntPtr AssemblyGetImage(IntPtr assembly);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_image_get_assembly")]
    public static partial IntPtr ImageGetAssembly(IntPtr image);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_image_get_name")]
    public static partial IntPtr ImageGetName(IntPtr image);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_image_get_filename")]
    public static partial IntPtr ImageGetFilename(IntPtr image);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_image_get_entry_point")]
    public static partial IntPtr ImageGetEntryPoint(IntPtr image);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_image_get_class_count")]
    public static partial nuint ImageGetClassCount(IntPtr image);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_image_get_class")]
    public static partial IntPtr ImageGetClass(IntPtr image, nuint index);

    // class
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_enum_basetype")]
    public static partial IntPtr ClassEnumBasetype(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_is_generic")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassIsGeneric(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_is_inflated")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassIsInflated(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_is_assignable_from")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassIsAssignableFrom(IntPtr klass, IntPtr oklass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_is_subclass_of")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassIsSubclassOf(IntPtr klass, IntPtr klassc, [MarshalAs(UnmanagedType.I1)] bool check_interfaces);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_has_parent")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassHasParent(IntPtr klass, IntPtr klassc);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_from_il2cpp_type")]
    public static partial IntPtr ClassFromIl2cppType(IntPtr type);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_from_name")]
    public static partial IntPtr ClassFromName(IntPtr image, [MarshalAs(UnmanagedType.LPStr)] string namespaze, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_from_system_type")]
    public static partial IntPtr ClassFromSystemType(IntPtr type);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_element_class")]
    public static partial IntPtr ClassGetElementClass(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_events")]
    public static partial IntPtr ClassGetEvents(IntPtr klass, ref IntPtr iter);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_fields")]
    public static partial IntPtr ClassGetFields(IntPtr klass, ref IntPtr iter);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_nested_types")]
    public static partial IntPtr ClassGetNestedTypes(IntPtr klass, ref IntPtr iter);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_interfaces")]
    public static partial IntPtr ClassGetInterfaces(IntPtr klass, ref IntPtr iter);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_properties")]
    public static partial IntPtr ClassGetProperties(IntPtr klass, ref IntPtr iter);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_property_from_name")]
    public static partial IntPtr ClassGetPropertyFromName(IntPtr klass, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_field_from_name")]
    public static partial IntPtr ClassGetFieldFromName(IntPtr klass, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_methods")]
    public static partial IntPtr ClassGetMethods(IntPtr klass, ref IntPtr iter);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_method_from_name")]
    public static partial IntPtr ClassGetMethodFromName(IntPtr klass, [MarshalAs(UnmanagedType.LPStr)] string name, int argsCount);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_name")]
    public static partial IntPtr ClassGetName(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_namespace")]
    public static partial IntPtr ClassGetNamespace(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_parent")]
    public static partial IntPtr ClassGetParent(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_declaring_type")]
    public static partial IntPtr ClassGetDeclaringType(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_instance_size")]
    public static partial int ClassInstanceSize(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_num_fields")]
    public static partial nuint ClassNumFields(IntPtr enumKlass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_is_valuetype")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassIsValueType(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_value_size")]
    public static partial int ClassValueSize(IntPtr klass, out uint align);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_is_blittable")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassIsBlittable(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_flags")]
    public static partial int ClassGetFlags(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_is_abstract")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassIsAbstract(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_is_interface")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassIsInterface(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_array_element_size")]
    public static partial int ClassArrayElementSize(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_from_type")]
    public static partial IntPtr ClassFromType(IntPtr type);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_type")]
    public static partial IntPtr ClassGetType(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_type_token")]
    public static partial uint ClassGetTypeToken(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_has_attribute")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassHasAttribute(IntPtr klass, IntPtr attr_class);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_has_references")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassHasReferences(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_is_enum")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ClassIsEnum(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_image")]
    public static partial IntPtr ClassGetImage(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_assemblyname")]
    public static partial IntPtr ClassGetAssemblyName(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_rank")]
    public static partial int ClassGetRank(IntPtr klass);

    // testing only
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_bitmap_size")]
    public static partial nuint ClassGetBitmapSize(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_class_get_bitmap")]
    public static partial void ClassGetBitmap(IntPtr klass, IntPtr bitmap);

    // stats
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_stats_dump_to_file")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool StatsDumpToFile([MarshalAs(UnmanagedType.LPStr)] string path);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_stats_get_value")]
    public static partial ulong StatsGetValue(int stat);

    // domain
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_domain_get")]
    public static partial IntPtr DomainGet();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_domain_assembly_open")]
    public static partial IntPtr DomainAssemblyOpen(IntPtr domain, [MarshalAs(UnmanagedType.LPStr)] string name);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_domain_get_assemblies")]
    public static partial IntPtr DomainGetAssemblies(IntPtr domain, out nuint size);

    // exception
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_raise_exception")]
    public static partial void RaiseException(IntPtr ex);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_exception_from_name_msg")]
    public static partial IntPtr ExceptionFromNameMsg(IntPtr image, [MarshalAs(UnmanagedType.LPStr)] string name_space, [MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string msg);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_get_exception_argument_null")]
    public static partial IntPtr GetExceptionArgumentNull([MarshalAs(UnmanagedType.LPStr)] string arg);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_format_exception")]
    public static partial void FormatException(IntPtr ex, IntPtr message, int message_size);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_format_stack_trace")]
    public static partial void FormatStackTrace(IntPtr ex, IntPtr output, int output_size);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_unhandled_exception")]
    public static partial void UnhandledException(IntPtr ex);

    // field
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_get_flags")]
    public static partial int FieldGetFlags(IntPtr field);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_get_name")]
    public static partial IntPtr FieldGetName(IntPtr field);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_get_parent")]
    public static partial IntPtr FieldGetParent(IntPtr field);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_get_offset")]
    public static partial nuint FieldGetOffset(IntPtr field);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_get_type")]
    public static partial IntPtr FieldGetType(IntPtr field);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_get_value")]
    public static partial void FieldGetValue(IntPtr obj, IntPtr field, IntPtr value);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_get_value_object")]
    public static partial IntPtr FieldGetValueObject(IntPtr field, IntPtr obj);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_has_attribute")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool FieldHasAttribute(IntPtr field, IntPtr attr_class);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_set_value")]
    public static partial void FieldSetValue(IntPtr obj, IntPtr field, IntPtr value);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_static_get_value")]
    public static partial void FieldStaticGetValue(IntPtr field, IntPtr value);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_static_set_value")]
    public static partial void FieldStaticSetValue(IntPtr field, IntPtr value);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_field_set_value_object")]
    public static partial void FieldSetValueObject(IntPtr instance, IntPtr field, IntPtr value);

    // gc
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gc_collect")]
    public static partial void GcCollect(int maxGenerations);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gc_collect_a_little")]
    public static partial int GcCollectALittle();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gc_disable")]
    public static partial void GcDisable();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gc_enable")]
    public static partial void GcEnable();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gc_is_disabled")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool GcIsDisabled();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gc_get_used_size")]
    public static partial long GcGetUsedSize();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gc_get_heap_size")]
    public static partial long GcGetHeapSize();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gc_wbarrier_set_field")]
    public static partial void GcWBarrierSetField(IntPtr obj, ref IntPtr targetAddress, IntPtr objValue);

    // gchandle
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gchandle_new")]
    public static partial uint GchandleNew(IntPtr obj, [MarshalAs(UnmanagedType.I1)] bool pinned);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gchandle_new_weakref")]
    public static partial uint GchandleNewWeakref(IntPtr obj, [MarshalAs(UnmanagedType.I1)] bool track_resurrection);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gchandle_get_target")]
    public static partial IntPtr GchandleGetTarget(uint gchandle);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_gchandle_free")]
    public static partial void GchandleFree(uint gchandle);

    // liveness
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_unity_liveness_calculation_begin")]
    public static partial IntPtr UnityLivenessCalculationBegin(IntPtr filter, int max_object_count, IntPtr callback, IntPtr userdata, IntPtr onWorldStarted, IntPtr onWorldStopped);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_unity_liveness_calculation_end")]
    public static partial void UnityLivenessCalculationEnd(IntPtr state);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_unity_liveness_calculation_from_root")]
    public static partial void UnityLivenessCalculationFromRoot(IntPtr root, IntPtr state);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_unity_liveness_calculation_from_statics")]
    public static partial void UnityLivenessCalculationFromStatics(IntPtr state);

    // method
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_get_return_type")]
    public static partial IntPtr MethodGetReturnType(IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_get_declaring_type")]
    public static partial IntPtr MethodGetDeclaringType(IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_get_name")]
    public static partial IntPtr MethodGetName(IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_get_from_reflection")]
    public static partial IntPtr MethodGetFromReflection(IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_get_object")]
    public static partial IntPtr MethodGetObject(IntPtr method, IntPtr refclass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_is_generic")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool MethodIsGeneric(IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_is_inflated")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool MethodIsInflated(IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_is_instance")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool MethodIsInstance(IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_get_param_count")]
    public static partial uint MethodGetParamCount(IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_get_param")]
    public static partial IntPtr MethodGetParam(IntPtr method, uint index);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_get_class")]
    public static partial IntPtr MethodGetClass(IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_has_attribute")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool MethodHasAttribute(IntPtr method, IntPtr attr_class);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_get_flags")]
    public static partial uint MethodGetFlags(IntPtr method, out uint iflags);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_get_token")]
    public static partial uint MethodGetToken(IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_method_get_param_name")]
    public static partial IntPtr MethodGetParamName(IntPtr method, uint index);

    // profiler (kept unconditional - can be wrapped in #if as needed)
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_profiler_install")]
    public static partial void ProfilerInstall(IntPtr prof, IntPtr shutdown_callback);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_profiler_set_events")]
    public static partial void ProfilerSetEvents(uint events);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_profiler_install_enter_leave")]
    public static partial void ProfilerInstallEnterLeave(IntPtr enter, IntPtr fleave);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_profiler_install_allocation")]
    public static partial void ProfilerInstallAllocation(IntPtr callback);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_profiler_install_gc")]
    public static partial void ProfilerInstallGc(IntPtr callback, IntPtr heap_resize_callback);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_profiler_install_fileio")]
    public static partial void ProfilerInstallFileio(IntPtr callback);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_profiler_install_thread")]
    public static partial void ProfilerInstallThread(IntPtr start, IntPtr end);

    // property
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_property_get_flags")]
    public static partial uint PropertyGetFlags(IntPtr prop);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_property_get_get_method")]
    public static partial IntPtr PropertyGetGetMethod(IntPtr prop);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_property_get_set_method")]
    public static partial IntPtr PropertyGetSetMethod(IntPtr prop);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_property_get_name")]
    public static partial IntPtr PropertyGetName(IntPtr prop);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_property_get_parent")]
    public static partial IntPtr PropertyGetParent(IntPtr prop);

    // object
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_object_get_class")]
    public static partial IntPtr ObjectGetClass(IntPtr obj);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_object_get_size")]
    public static partial uint ObjectGetSize(IntPtr obj);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_object_get_virtual_method")]
    public static partial IntPtr ObjectGetVirtualMethod(IntPtr obj, IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_object_new")]
    public static partial IntPtr ObjectNew(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_object_unbox")]
    public static partial IntPtr ObjectUnbox(IntPtr obj);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_value_box")]
    public static partial IntPtr ValueBox(IntPtr klass, IntPtr data);

    // monitor
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_monitor_enter")]
    public static partial void MonitorEnter(IntPtr obj);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_monitor_try_enter")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool MonitorTryEnter(IntPtr obj, uint timeout);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_monitor_exit")]
    public static partial void MonitorExit(IntPtr obj);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_monitor_pulse")]
    public static partial void MonitorPulse(IntPtr obj);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_monitor_pulse_all")]
    public static partial void MonitorPulseAll(IntPtr obj);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_monitor_wait")]
    public static partial void MonitorWait(IntPtr obj);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_monitor_try_wait")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool MonitorTryWait(IntPtr obj, uint timeout);

    // runtime
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_runtime_invoke")]
    public static partial IntPtr RuntimeInvoke(IntPtr method, IntPtr obj, IntPtr parameters, out IntPtr exc);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_runtime_invoke_convert_args")]
    public static partial IntPtr RuntimeInvokeConvertArgs(IntPtr method, IntPtr obj, IntPtr parameters, int paramCount, out IntPtr exc);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_runtime_class_init")]
    public static partial void RuntimeClassInit(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_runtime_object_init")]
    public static partial void RuntimeObjectInit(IntPtr obj);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_runtime_object_init_exception")]
    public static partial void RuntimeObjectInitException(IntPtr obj, out IntPtr exc);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_runtime_unhandled_exception_policy_set")]
    public static partial void RuntimeUnhandledExceptionPolicySet(int value);

    // string
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_string_length")]
    public static partial int StringLength(IntPtr str);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_string_chars")]
    public static partial IntPtr StringChars(IntPtr str);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_string_new")]
    public static partial IntPtr StringNew([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_string_new_len")]
    public static partial IntPtr StringNewLen([MarshalAs(UnmanagedType.LPStr)] string str, uint length);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_string_new_utf16")]
    public static partial IntPtr StringNewUtf16(IntPtr text, int len);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_string_new_wrapper")]
    public static partial IntPtr StringNewWrapper([MarshalAs(UnmanagedType.LPStr)] string str);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_string_intern")]
    public static partial IntPtr StringIntern(IntPtr str);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_string_is_interned")]
    public static partial IntPtr StringIsInterned(IntPtr str);

    // thread
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_thread_current")]
    public static partial IntPtr ThreadCurrent();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_thread_attach")]
    public static partial IntPtr ThreadAttach(IntPtr domain);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_thread_detach")]
    public static partial void ThreadDetach(IntPtr thread);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_thread_get_all_attached_threads")]
    public static partial IntPtr ThreadGetAllAttachedThreads(out nuint size);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_is_vm_thread")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsVmThread(IntPtr thread);

    // stacktrace
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_current_thread_walk_frame_stack")]
    public static partial void CurrentThreadWalkFrameStack(IntPtr func, IntPtr user_data);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_thread_walk_frame_stack")]
    public static partial void ThreadWalkFrameStack(IntPtr thread, IntPtr func, IntPtr user_data);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_current_thread_get_top_frame")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CurrentThreadGetTopFrame(IntPtr frame);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_thread_get_top_frame")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ThreadGetTopFrame(IntPtr thread, IntPtr frame);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_current_thread_get_frame_at")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CurrentThreadGetFrameAt(int offset, IntPtr frame);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_thread_get_frame_at")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool ThreadGetFrameAt(IntPtr thread, int offset, IntPtr frame);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_current_thread_get_stack_depth")]
    public static partial int CurrentThreadGetStackDepth();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_thread_get_stack_depth")]
    public static partial int ThreadGetStackDepth(IntPtr thread);

    // type
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_type_get_object")]
    public static partial IntPtr TypeGetObject(IntPtr type);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_type_get_type")]
    public static partial int TypeGetType(IntPtr type);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_type_get_class_or_element_class")]
    public static partial IntPtr TypeGetClassOrElementClass(IntPtr type);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_type_get_name")]
    public static partial IntPtr TypeGetName(IntPtr type);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_type_is_byref")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool TypeIsByRef(IntPtr type);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_type_get_attrs")]
    public static partial uint TypeGetAttrs(IntPtr type);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_type_equals")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool TypeEquals(IntPtr type, IntPtr otherType);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_type_get_assembly_qualified_name")]
    public static partial IntPtr TypeGetAssemblyQualifiedName(IntPtr type);

    // Memory information
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_capture_memory_snapshot")]
    public static partial IntPtr CaptureMemorySnapshot();

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_free_captured_memory_snapshot")]
    public static partial void FreeCapturedMemorySnapshot(IntPtr snapshot);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_set_find_plugin_callback")]
    public static partial void SetFindPluginCallback(IntPtr method);

    // Logging
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_register_log_callback")]
    public static partial void RegisterLogCallback(IntPtr method);

    // Debugger
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_debugger_set_agent_options")]
    public static partial void DebuggerSetAgentOptions([MarshalAs(UnmanagedType.LPStr)] string options);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_is_debugger_attached")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool IsDebuggerAttached();

    // TLS module
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_unity_install_unitytls_interface")]
    public static partial void UnityInstallUnityTlsInterface(IntPtr unitytlsInterfaceStruct);

    // custom attributes
    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_custom_attrs_from_class")]
    public static partial IntPtr CustomAttrsFromClass(IntPtr klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_custom_attrs_from_method")]
    public static partial IntPtr CustomAttrsFromMethod(IntPtr method);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_custom_attrs_get_attr")]
    public static partial IntPtr CustomAttrsGetAttr(IntPtr ainfo, IntPtr attr_klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_custom_attrs_has_attr")]
    [return: MarshalAs(UnmanagedType.I1)]
    public static partial bool CustomAttrsHasAttr(IntPtr ainfo, IntPtr attr_klass);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_custom_attrs_construct")]
    public static partial IntPtr CustomAttrsConstruct(IntPtr cinfo);

    [LibraryImport(GameAssembly, EntryPoint = "il2cpp_custom_attrs_free")]
    public static partial void CustomAttrsFree(IntPtr ainfo);

}
