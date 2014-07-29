module.exports = function (grunt) {


grunt.initConfig({
	
	pkg: grunt.file.readJSON('package.json'),
        
  // SASS CSS
  sass: {
    all: {
      files: [
                { cwd: 'Trouper.UI/Client/SASS', src: ['**/*.scss', '!_*/**/*.scss', '!*/**/_*.scss'], dest: 'Trouper.UI/Client/Styles', ext: '.css', expand: true },
                { cwd: 'Trouper.UI/Views/Partials/Components', src: ['**/*.scss', '!_*/**/*.scss', '!*/**/_*.scss'], dest: 'Trouper.UI/Views/Partials/Components', ext: '.css', expand: true }
             ]
      }
    },
  watch: {
      css: {
        files: '**/*.scss',
        tasks: ['compass']
      }
    }

  })
	
    // Default task(s).
  grunt.loadNpmTasks('grunt-contrib-sass');
  grunt.loadNpmTasks('grunt-contrib-compass');
  grunt.loadNpmTasks('grunt-contrib-watch');
  grunt.registerTask('default',['sass']);

};