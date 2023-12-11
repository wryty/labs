<?php

// autoload_static.php @generated by Composer

namespace Composer\Autoload;

class ComposerStaticInitf10d8455d8b1780d62e87939fb4b1856
{
    public static $files = array (
        '9b38cf48e83f5d8f60375221cd213eee' => __DIR__ . '/..' . '/phpstan/phpstan/bootstrap.php',
    );

    public static $prefixLengthsPsr4 = array (
        'P' => 
        array (
            'PizzaStore\\' => 11,
        ),
    );

    public static $prefixDirsPsr4 = array (
        'PizzaStore\\' => 
        array (
            0 => __DIR__ . '/../..' . '/src',
        ),
    );

    public static $classMap = array (
        'Composer\\InstalledVersions' => __DIR__ . '/..' . '/composer/InstalledVersions.php',
    );

    public static function getInitializer(ClassLoader $loader)
    {
        return \Closure::bind(function () use ($loader) {
            $loader->prefixLengthsPsr4 = ComposerStaticInitf10d8455d8b1780d62e87939fb4b1856::$prefixLengthsPsr4;
            $loader->prefixDirsPsr4 = ComposerStaticInitf10d8455d8b1780d62e87939fb4b1856::$prefixDirsPsr4;
            $loader->classMap = ComposerStaticInitf10d8455d8b1780d62e87939fb4b1856::$classMap;

        }, null, ClassLoader::class);
    }
}
