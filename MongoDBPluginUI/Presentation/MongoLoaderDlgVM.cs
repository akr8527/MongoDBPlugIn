﻿//  Copyright 2012 ESRI

//  All rights reserved under the copyright laws of the United States.

//  You may freely redistribute and use this sample code, with or without modification.

//  Disclaimer: THE SAMPLE CODE IS PROVIDED "AS IS" AND ANY EXPRESS OR IMPLIED
//  WARRANTIES, INCLUDING THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS
//  FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL ESRI OR
//  CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY,
//  OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
//  SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
//  INTERRUPTION) SUSTAINED BY YOU OR A THIRD PARTY, HOWEVER CAUSED AND ON ANY
//  THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT ARISING IN ANY
//  WAY OUT OF THE USE OF THIS SAMPLE CODE, EVEN IF ADVISED OF THE POSSIBILITY OF
//  SUCH DAMAGE.

//  For additional information contact: Environmental Systems Research Institute, Inc.
//  Attn: Contracts Dept.

//  380 New York Street

//  Redlands, California, U.S.A. 92373

//  Email: contracts@esri.com

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDBPluginUI
{
  public class MongoLoaderDlgVM
          : MongoDbDialogVM,
            IMongoDbLoaderDlgVm
  {

    MongoConnectionBrowseVM _SourceVM = new MongoConnectionBrowseVM();
    public MongoConnectionBrowseVM SourceVM
    {
      get
      {
        return _SourceVM;
      }
    }

    public void SetSourceBrowse(ButtonInfo bi)
    {
      SourceVM.OnBrowse = new ButtonCmd(bi);
    }
    public string FCConn
    {
      get
      {
        return SourceVM.File;
      }
      set
      {
        SourceVM.File = value;
      }
    }
  }
}
