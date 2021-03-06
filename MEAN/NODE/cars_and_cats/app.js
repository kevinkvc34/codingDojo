const http = require('http');
const fs = require('fs');
const server = http.createServer(function (request, response){
    console.log('client request URL: ', request.url);
    
    // this is how we do routing:
    if(request.url === '/cars') {
        fs.readFile('views/cars.html', 'utf8', function (errors, contents){
            response.writeHead(200, {'Content-Type': 'text/html'});  // send data about response
            response.write(contents);  //  send response body
            response.end(); // finished!
        });
    }
    else if(request.url === '/images/dog.jpg') {
        fs.readFile('./images/dog.jpg',function (errors, contents) {
            response.writeHead(200, {'Content-Type': 'image/jpg'})
            response.write(contents);
            response.end();
        })
    }
    else if(request.url === '/stylesheets/cars.css') {
        fs.readFile('./stylesheets/cars.css', 'utf-8',function (errors, contents) {
            response.writeHead(200, {'Content-Type': 'text/css'})
            response.write(contents);
            response.end();
        })
    }
    else if(request.url === '/cats') {
        fs.readFile('views/cats.html', 'utf8', function(errors, contents) {
            response.writeHead(200, {'Content-type' : 'text/html'})
            response.write(contents);
            response.end();
        })
    }
    else if(request.url === '/images/cat.jpg') {
        fs.readFile('./images/cat.jpg',function (errors, contents) {
            response.writeHead(200, {'Content-Type': 'image/jpg'})
            response.write(contents);
            response.end();
        })
    }
    else if(request.url === '/stylesheets/cats.css') {
        fs.readFile('./stylesheets/cats.css', 'utf-8',function (errors, contents) {
            response.writeHead(200, {'Content-Type': 'text/css'})
            response.write(contents);
            response.end();
        })
    }
    else if(request.url === '/cars/new') {
        fs.readFile('views/carform.html', 'utf8', function(errors, contents) {
            response.writeHead(200, {'Content-type' : 'text/html'})
            response.write(contents);
            response.end();
        })
    }
    // request didn't match anything:
    else {
        response.writeHead(404);
        response.end('File not found!!!');
    }
});
// tell your server which port to run on
server.listen(6789);
// print to terminal window
console.log("Running in localhost at port 6789");