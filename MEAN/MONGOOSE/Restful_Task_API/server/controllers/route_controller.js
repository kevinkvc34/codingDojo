const mongoose = require('mongoose');
const Task = mongoose.model('Task');

module.exports = {
    index: (request, response) => {
        Task.find({})
          .then(data => {
              response.json(data);
          })
          .catch(err => {
              console.log(err);
          })
    },
    view_task: (request, response) => {
        const {id} = request.params;
        Task.find({_id: id})
          .then(data => {
              response.json(data);
          })
          .catch(err => {
              console.log(err);
          })
    },
    make_task: (request, response) => {
        Task.create(request.body)
          .then(data => {
              data.save();
              response.json(data);
          })
          .catch(err => {
              console.log(err);
          })
    },
    put_task: (request, response) => {
        const { id } = request.params;
        Task.update({_id: id}, request.body)
          .then(data => {
            response.json(data);
          })
          .catch(err => {
              console.log(err);
          })
    },
    del_task: (request, response) => {
        const { id } = request.params;
        Task.deleteOne({_id: id})
          .then(data => {
              response.json(data);
          })
          .catch(err => {
              console.log(err);
          })
    }
}