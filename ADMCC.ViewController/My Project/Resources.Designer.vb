﻿'------------------------------------------------------------------------------
' <auto-generated>
'     O código foi gerado por uma ferramenta.
'     Versão de Tempo de Execução:4.0.30319.42000
'
'     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
'     o código for gerado novamente.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    'através de uma ferramenta como ResGen ou Visual Studio.
    'Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    'com a opção /str, ou recrie o projeto do VS.
    '''<summary>
    '''  Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ADMCC.ViewController.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Substitui a propriedade CurrentUICulture do thread atual para todas as
        '''  pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
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
        '''  Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property add_16() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("add_16", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property disk() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("disk", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property korganizer() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("korganizer", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property lupa() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("lupa", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property lupaExclui() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("lupaExclui", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property mais() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("mais", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Save() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Save", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
