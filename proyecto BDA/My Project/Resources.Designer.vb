﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'StronglyTypedResourceBuilder generó automáticamente esta clase
    'a través de una herramienta como ResGen o Visual Studio.
    'Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    'con la opción /str o recompile su proyecto de VS.
    '''<summary>
    '''  Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("proyecto_BDA.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        '''  búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property controlxbox() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("controlxbox", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CTR() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CTR", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property dbz() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("dbz", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property dualshock4() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("dualshock4", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Ezio() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Ezio", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ff7() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ff7", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Gow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Gow", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property joycons() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("joycons", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property KH_Close_Menu() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("KH_Close_Menu", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property KH_Menu_Extend() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("KH_Menu_Extend", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property KH_Menu_Select() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("KH_Menu_Select", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property KH_Nav_Sound() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("KH_Nav_Sound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property KH_Save_Sound() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("KH_Save_Sound", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property KH_Select() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("KH_Select", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.IO.UnmanagedMemoryStream similar a System.IO.MemoryStream.
        '''</summary>
        Friend ReadOnly Property KH_Unavailable() As System.IO.UnmanagedMemoryStream
            Get
                Return ResourceManager.GetStream("KH_Unavailable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property kh3() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("kh3", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ps4() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ps4", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property re2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("re2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property smash() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("smash", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property south_park() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("south_park", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property spiderman() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("spiderman", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property star_wars() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("star_wars", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property switch() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("switch", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property tlou() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("tlou", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Busca un recurso adaptado de tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property xbox() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("xbox", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace