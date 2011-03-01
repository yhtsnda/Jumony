﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Ivony.Html.Web
{
  public class NoResponseHttpContext : HttpContextWrapper
  {

    public NoResponseHttpContext( HttpContext context ) : base( context ) { }

    public override HttpResponseBase Response
    {
      get { throw new NotSupportedException( "在当前上下文中，无法产生任何响应" ); }
    }

    public override void RemapHandler( IHttpHandler handler )
    {
      throw new NotSupportedException( "此操作在当前上下文中不受支持" );
    }

    public override void RewritePath( string filePath, string pathInfo, string queryString )
    {
      throw new NotSupportedException( "此操作在当前上下文中不受支持" );
    }

    public override void RewritePath( string filePath, string pathInfo, string queryString, bool setClientFilePath )
    {
      throw new NotSupportedException( "此操作在当前上下文中不受支持" );
    }

    public override void RewritePath( string path )
    {
      throw new NotSupportedException( "此操作在当前上下文中不受支持" );
    }

    public override void RewritePath( string path, bool rebaseClientPath )
    {
      throw new NotSupportedException( "此操作在当前上下文中不受支持" );
    }

  }
}
