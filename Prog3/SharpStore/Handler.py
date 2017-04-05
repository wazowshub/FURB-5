import BaseHTTPServer

class MyHandler(BaseHTTPServer.BaseHTTPRequestHandler):
	def do_GET(s):	
		path = s.path[1:]
		print path
		if s.path == "/":
			f = open("index.html")
			s.send_response(200)
			s.send_header('Location', '/index.html')
			s.send_header('Content-type','text/html')
			s.end_headers()
			s.wfile.write(f.read())
			f.close()
			return
		if s.path.endswith(".css"):
			f = open(path)
			s.send_response(200)
			s.send_header('Content-type','text/css')
			s.end_headers()
			s.wfile.write(f.read())
			f.close()
			return
		if s.path.endswith(".png"):
			f = open(path, "rb")
			s.send_response(200)
			s.send_header('Content-type','image/png')
			s.end_headers()
			s.wfile.write(f.read())
			f.close()
			return
		if s.path.endswith(".js"):
			f = open(path)
			s.send_response(200)
			s.send_header('Content-type','text/javascript')
			s.end_headers()
			s.wfile.write(f.read())
			f.close()
			return
		if s.path.endswith(".jpg"):
			f = open(path, "rb")
			s.send_response(200)
			s.send_header('Content-type','image/jpeg')
			s.end_headers()
			s.wfile.write(f.read())
			f.close()
			return
		if s.path.endswith(".woff"):
			f = open(path, 'rb')
			s.send_response(200)
			s.send_header('Content-type',"application/x-font-woff")
			s.end_headers()
			s.wfile.write(f.read())
			f.close()
			return
		if s.path.endswith(".gif"):
			f = open(path)
			s.send_response(200)
			s.send_header('Content-type','image/gif')
			s.end_headers()
			s.wfile.write(f.read())
			f.close()
			return
		if s.path.endswith(".ttf"):
			f = open(path)
			s.send_response(200)
			s.send_header('Content-type','font/ttf')
			s.end_headers()
			s.wfile.write(f.read())
			f.close()
			return
		if s.path.endswith(".eot"):
			f = open(path)
			s.send_response(200)
			s.send_header('Content-type','application/vnd.ms-fontobject')
			s.end_headers()
			s.wfile.write(f.read())
			f.close()
			return
		if s.path.endswith(".svg"):
			f = open(path)
			s.send_response(200)
			s.send_header('Content-type','image/svg+xml')
			s.end_headers()
			s.wfile.write(f.read())
			f.close()
			return





			