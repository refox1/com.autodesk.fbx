function(stevedore command)
    if(${command} STREQUAL "internal-unpack")
        list(GET ARGN 0 repo_name)
        list(GET ARGN 1 artifact_id)
        list(GET ARGN 2 target_path)
    else()
        message(FATAL_ERROR "Unsupported command `${command}'")
    endif()

    if(${CMAKE_SYSTEM_NAME} STREQUAL "Darwin")
        find_program(MONO mono)
    elseif(${CMAKE_SYSTEM_NAME} STREQUAL "Linux")
        find_program(MONO mono)
        get_filename_component(MONO_DIR ${MONO} DIRECTORY)
        set(MONO_CONFIG ${MONO_DIR}/../etc-linux64/mono/config)
    else()
        set(MONO "")
    endif()

    if("${MONO}" STREQUAL "MONO-NOTFOUND")
        message(FATAL "mono required by bee.exe was not found!")
    endif()

    find_program(BEE bee.exe HINTS ${CMAKE_SOURCE_DIR})
    if(${BEE} STREQUAL "BEE-NOTFOUND")
        message(FATAL "bee.exe required by Stevedore was not found in ${CMAKE_SOURCE_DIR}")
    endif()

    find_program(7ZA NAMES 7za 7z HINTS "C:/Program Files/7-Zip")
    if(${7ZA} STREQUAL "7ZA-NOTFOUND")
        message(FATAL "7z required by Stevedore was not found")
    endif()
    message(STATUS "Stevedore fetching ${repo_name}:${artifact_id} to ${target_path}")
    file(TO_NATIVE_PATH "${7ZA}" 7ZA_NATIVE)

    set(BEE_OUTPUT "")
    set(BEE_EXIT -1)
    # Quoting the 7za argument on windows is required and on linux/mac is forbidden.
    if(WIN32)
        execute_process(COMMAND ${CMAKE_COMMAND} -E env BEE_INTERNAL_STEVEDORE_7ZA=${7ZA_NATIVE} ${MONO} ${BEE} steve internal-unpack ${repo_name} ${artifact_id} ${target_path} ERROR_VARIABLE BEE_OUTPUT OUTPUT_VARIABLE BEE_OUTPUT RESULT_VARIABLE BEE_EXIT)
    else()

        execute_process(COMMAND ${CMAKE_COMMAND} -E env BEE_INTERNAL_STEVEDORE_7ZA=${7ZA_NATIVE} ${MONO} ${BEE} steve internal-unpack ${repo_name} ${artifact_id} ${target_path} ERROR_VARIABLE BEE_OUTPUT OUTPUT_VARIABLE BEE_OUTPUT RESULT_VARIABLE BEE_EXIT)
        
    endif()
    if(NOT ${BEE_EXIT} STREQUAL 0)
        message(FATAL "bee.exe failed with error code ${BEE_EXIT}. Bee output: ${BEE_OUTPUT}")
    endif()
endfunction()
