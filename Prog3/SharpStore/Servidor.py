# encoding: utf-8
import BaseHTTPServer
import Handler

h = BaseHTTPServer.HTTPServer(("",3128),Handler.MyHandler)
h.serve_forever()