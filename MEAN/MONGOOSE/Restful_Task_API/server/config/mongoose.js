const mongoose = require('mongoose');
const path = require('path');
const fs = require('fs');
module.exports = {
    main: () => {
        mongoose.connect('mongodb://localhost/task_db', {useNewUrlParser: true});
        var models_path = path.join(__dirname, './../models');
        fs.readdirSync(models_path).forEach(function(file) {
            if(file.indexOf('.js') >= 0) {
                require(models_path + '/' + file);
            }
        })
    }
}